using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

using KntLibrary.DAO.Sqlite;

namespace SimpleTabBrowser.Components
{
	/// <summary>
	/// うぇぶぶらうざ v2(マルチタブブラウザ仕様)
	/// </summary>
	/// <author>Yamada Kenta</author>
	public partial class MainForm : Form
	{
		#region Fields

		/// <summary>ブラウザでの空白</summary>
		private const string _Blank = "about:blank";
		
		/// <summary>削除対象のブックマーク</summary>
		private ToolStripMenuItem _innerDeleteBookmark = null;

		/// <summary>ブックマーク内部保持</summary>
		private List<Bookmark> _innerBookmarks = null;

		/// <summary>スタートアップページ</summary>
		public string DefaultHomePage { get; set; }

		/// <summary>スタートアップページタイトル</summary>
		public string DefaultHomePageTitle { get; set; }

		/// <summary>ブックマークタイトル</summary>
		public string BookmarkTitle { get; set; }

		#endregion

		#region Constructors

		public MainForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Events

		#region フォーム関連処理

		/// <summary>
		/// 起動時イベント
		/// </summary>
		private void MainForm_Load(object sender, EventArgs e)
		{
			//ネットワーク接続確認
			if (!this.CanConnectInternet())
			{
				MessageBox.Show("ネットワーク接続に失敗しました。ネットワークの接続を確認して下さい。",
								"ネットワーク接続エラー",
								MessageBoxButtons.OK,
								MessageBoxIcon.Warning);

				return;
			}
			
			this.Initialize();

			this.InitializeBookmarkMenu();

			this.Navigate(this.DefaultHomePage);
		}

		/// <summary>
		/// フォームサイズ変更時イベント
		/// </summary>
		private void MainForm_Resize(object sender, EventArgs e)
		{
			this.txtCurrentUrl.Width = this.toolStrip1.Width - 200;
		}

		/// <summary>
		/// フォームクローズドイベント
		/// </summary>
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();

			//ブックマークデータをDBファイルへ保存する
			try
			{
				SqliteCommander.Delete(Sql.DeleteBookmarksSql);
				SqliteCommander.Save(Sql.InsertBookmarksSql(this._innerBookmarks));
			}
			catch
			{
				MessageBox.Show("アプリケーションエラーが発生したため終了します。");
				Application.Exit();
			}

			Application.Exit();
		}

		/// <summary>
		/// Current URL KeyDown event
		/// </summary>
		private void txtCurrentUrl_KeyDown(object sender, KeyEventArgs e)
		{
			if (Keys.Enter == e.KeyCode)
			{
				this.Navigate(this.txtCurrentUrl.Text);
			}
		}

		#endregion

		#region ブラウザ関係

		/// <summary>
		/// URLナビゲーション後イベント
		/// </summary>
		private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			if (null != currentBrowser)
			{
				this.txtCurrentUrl.Text = Convert.ToString(currentBrowser.Url);
			}
		}

		/// <summary>
		/// ステータステキスト変更後イベント
		/// </summary>
		private void webBrowser_StatusTextChanged(object sender, EventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			if (null != currentBrowser)
			{
				this.toolStripStatusLabel1.Text = currentBrowser.StatusText;
			}
		}

		/// <summary>
		/// ダウンロード進行状況伝播イベント
		/// </summary>
		private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
		{
			long max = e.MaximumProgress;
			long current = e.CurrentProgress;

			if (0 < max)
			{
				this.ProgressBar.Maximum = (int)max;
			}
			else if (0 <= current && current <= max)
			{
				this.ProgressBar.Value = (int)current;
			}
			else if (current < 0 || max == 0)
			{
				this.ProgressBar.Value = 0;
			}
		}

		/// <summary>
		/// Webページタイトル変更後イベント
		/// </summary>
		private void webBrowser_DocumentTitleChanged(object sender, EventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			if (null != currentBrowser)
			{
				string title = currentBrowser.DocumentTitle;

				if (30 < currentBrowser.DocumentTitle.Length)
				{
					this.tabControl1.SelectedTab.Text = title.Substring(0, 30);
				}
				else
				{
					this.tabControl1.SelectedTab.Text = title;
				}
			}
		}

		/// <summary>
		/// Webページタイトル変更完了後イベント
		/// </summary>
		private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			if (null != currentBrowser)
			{
				this.btnGoBack.Enabled = currentBrowser.CanGoBack;
				this.btnGoForward.Enabled = currentBrowser.CanGoForward;
			}
		}

		/// <summary>
		/// 新しいウィンドウを開くイベント
		/// </summary>
		private void webBrowser_NewWindow(object sender, CancelEventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser(sender);

			if (null != currentBrowser)
			{
				this.AddTabWindow(currentBrowser.StatusText);
			}

			e.Cancel = true;
		}

		/// <summary>
		/// 「タブの追加」クリック
		/// </summary>
		private void AddTabPage_Click(object sender, EventArgs e)
		{
			this.AddTabWindow(this.DefaultHomePage);
		}

		/// <summary>
		/// タブページ削除
		/// </summary>
		private void DelTabPage_Click(object sender, EventArgs e)
		{
			if (this.tabControl1.TabPages.Count <= 1)
			{
				this.Close();
				return;
			}
			
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			if (null != currentBrowser)
			{
				//イベントフック解除
				currentBrowser.DocumentTitleChanged -= new EventHandler(webBrowser_DocumentTitleChanged);
				currentBrowser.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);
				currentBrowser.StatusTextChanged -= new EventHandler(webBrowser_StatusTextChanged);
				currentBrowser.Navigated -= new WebBrowserNavigatedEventHandler(webBrowser_Navigated);
				currentBrowser.ProgressChanged -= new WebBrowserProgressChangedEventHandler(webBrowser_ProgressChanged);
				currentBrowser.NewWindow -= new CancelEventHandler(webBrowser_NewWindow);

				//タブページ上のウェブブラウザコントロールを削除、リソース解放
				TabPage tabPage = this.tabControl1.SelectedTab;

				tabPage.Controls.Remove(currentBrowser);
				currentBrowser.Dispose();
				currentBrowser = null;

				//タブページ削除
				this.tabControl1.TabPages.Remove(tabPage);
				tabPage.Dispose();
				tabPage = null;

				this.tabControl1.SelectedTab = this.tabControl1.TabPages[this.tabControl1.TabPages.Count - 1];
			}
		}

		#endregion

		#region ファイルメニュー関連
		/// <summary>
		/// 「ファイルを開く」クリック
		/// </summary>
		private void menuFileOpen_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.FileName = string.Empty;

			if (DialogResult.OK != this.openFileDialog1.ShowDialog())
			{
				return;
			}

			this.Navigate(this.openFileDialog1.FileName);
		}

		/// <summary>
		/// 「名前をつけて保存」クリック
		/// </summary>
		private void menuSaveAsName_Click(object sender, EventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			currentBrowser.ShowSaveAsDialog();
		}

		/// <summary>
		/// 「ページ設定」クリック
		/// </summary>
		private void menuSettingPage_Click(object sender, EventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			currentBrowser.ShowPageSetupDialog();
		}

		/// <summary>
		/// 「印刷」クリック
		/// </summary>
		private void menuPrint_Click(object sender, EventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			currentBrowser.ShowPrintDialog();
		}

		/// <summary>
		/// 「印刷プレビュー」クリック
		/// </summary>
		private void menuPreview_Click(object sender, EventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			currentBrowser.ShowPrintPreviewDialog();
		}

		/// <summary>
		/// 「終了」クリック
		/// </summary>
		private void menuExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region ブックマークメニュー関連

		/// <summary>
		/// 「ブックマークの追加」クリック
		/// </summary>
		private void menuAddBookmark_Click(object sender, EventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			if (null == currentBrowser)
			{
				return;
			}

            var dlg = new BookmarkTitleEditor();

            dlg.MainDisplay = this;
            dlg.BookmarkTitle = currentBrowser.DocumentTitle;

            if (DialogResult.OK == this.ShowBookmarkEditor(currentBrowser.DocumentTitle))
            {
                this.AddBookmarkMenu(this.BookmarkTitle, currentBrowser.Url.ToString());
            }
		}

		/// <summary>
		/// ブックマークタイトルクリック
		/// </summary>
		private void BookmarkTitle_Click(object sender, EventArgs e)
		{
			string name = (sender as ToolStripMenuItem).Text;

			var target = (from t in this._innerBookmarks
						  where t.Title == name
						  select t.Url).ToArray();
						 
			this.Navigate(target[0]);
		}

		/// <summary>
		/// 「ブックマークの削除」表示
		/// </summary>
		private void BookmarkDelete_MouseUp(object sender, MouseEventArgs e)
		{
			var item = sender as ToolStripMenuItem;

			if (e.Button == MouseButtons.Right)
			{
				this._innerDeleteBookmark = item;
				this.deleteBookmark.Text = "「" + item.Text + "」を削除(&D)";
				this.contextMenuStrip2.Show(MousePosition);
			}
		}

		/// <summary>
		/// 「ブックマーク削除」クリック
		/// </summary>
		private void deleteBookmark_Click(object sender, EventArgs e)
		{
			this.menuBookmark.DropDownItems.Remove(this._innerDeleteBookmark);

			var target = (from t in this._innerBookmarks
						  where t.Title == this._innerDeleteBookmark.Text
						  select t).ToArray();

			if (0 < target.Length)
			{
				this._innerBookmarks.Remove(target[0]);
			}
		}
		#endregion

		#region オプションメニュー関連

		/// <summary>
		/// 「ホームページ設定」クリック
		/// </summary>
		private void menuHomepageOption_Click(object sender, EventArgs e)
		{
			var dlg = new HomepageOption();

			dlg.ShowDialog();
		}

		/// <summary>
		/// 「URL履歴」のクリア
		/// </summary>
		private void menuClearUrl_Click(object sender, EventArgs e)
		{
			//this._History.MainData.Clear();

			//this._History.Clear();

			//this.UpdateUrlList();
		}

		/// <summary>
		/// 「バージョン情報」クリック
		/// </summary>
		private void menuVersion_Click(object sender, EventArgs e)
		{
			var dlg = new VersionDialog();
			dlg.Show();
		}

		#endregion

		#region メニューバー関連

		/// <summary>
		/// 「戻る」クリック
		/// </summary>
		private void btnGoBack_Click(object sender, EventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			if (null != currentBrowser)
			{
				currentBrowser.GoBack();
			}
		}

		/// <summary>
		/// 「進む」クリック
		/// </summary>
		private void btnGoForward_Click(object sender, EventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			if (null != currentBrowser)
			{
				currentBrowser.GoForward();
			}
		}

		/// <summary>
		/// 「最新の状態にする」クリック
		/// </summary>
		private void btnReflesh_Click(object sender, EventArgs e)
		{
			WebBrowser currentBrowser = this.GetCurrentBrowser();

			if (null != currentBrowser)
			{
				currentBrowser.Refresh();
			}
		}

		/// <summary>
		/// 「ホームへ」クリック
		/// </summary>
		private void btnHome_Click(object sender, EventArgs e)
		{
			try
			{
				var table = new DataTable();
				table = SqliteCommander.Select(Sql.GetStartupSql);

				if(0 < table.Rows.Count)
				{
					this.DefaultHomePage = table.Rows[0]["url"].ToString();
				}
			}
			catch
			{
				MessageBox.Show("アプリケーションエラー発生");
			}

			this.Navigate(this.DefaultHomePage);
		}

		#endregion

		#endregion

		#region Private Methods

		#region アプリケーション初期設定関連

		/// <summary>
		/// インターネット接続確認
		/// </summary>
		/// <returns>True:使用可能 False:使用不可</returns>
		private bool CanConnectInternet()
		{
			return NetworkInterface.GetIsNetworkAvailable();
		}

		/// <summary>
		/// 初期化設定
		/// </summary>
		private void Initialize()
		{
			this._innerBookmarks = new List<Bookmark>();

			this.webBrowser1.StatusTextChanged += new EventHandler(webBrowser_StatusTextChanged);
			this.webBrowser1.DocumentTitleChanged += new EventHandler(webBrowser_DocumentTitleChanged);

			this.openFileDialog1.Filter = "HTMLファイル(*.htm;*.html;*.mht)|*.htm;*.html;*.mht|すべてのファイル(*.*)|*.*";
			this.txtCurrentUrl.Width = this.toolStrip1.Width - 180;
		}

		#endregion

		#region ブラウザ関連

		/// <summary>
		/// URL誘導
		/// </summary>
		/// <param name="destination"></param>
		private void Navigate(string destination)
		{
			if (this.IsUrl(destination))
			{
				return;
			}

			WebBrowser currentBrowser = this.GetCurrentBrowser();

			if (null != currentBrowser)
			{
				currentBrowser.Navigate(destination);
			}
		}

		/// <summary>
		/// 閲覧中のブラウザコントロール取得
		/// </summary>
		/// <returns>閲覧中のブラウザコントロール</returns>
		private WebBrowser GetCurrentBrowser()
		{
			return this.tabControl1.SelectedTab.Controls[0] as WebBrowser;
		}

		private WebBrowser GetCurrentBrowser(object value)
		{
			return value as WebBrowser;
		}

		/// <summary>
		/// URL Nullチェック
		/// </summary>
		/// <param name="url">URLアドレス</param>
		/// <returns>True:Null / False:Not Null</returns>
		private bool IsUrl(string url)
		{
			if (string.IsNullOrWhiteSpace(url) && _Blank == url)
			{
				MessageBox.Show("ＵＲＬを入力して下さい。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}

			return false;
		}

		/// <summary>
		/// タブページ追加
		/// </summary>
		/// <param name="url">URL</param>
		private void AddTabWindow(string url)
		{
			var newPage = new TabPage();
			var newBrowser = new WebBrowser();

			//WebBrowserコントロール各種設定
			newBrowser.Dock = DockStyle.Fill;
			newBrowser.ScriptErrorsSuppressed = true;

			//イベントフック
			newBrowser.DocumentTitleChanged += new EventHandler(webBrowser_DocumentTitleChanged);
			newBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);
			newBrowser.StatusTextChanged += new EventHandler(webBrowser_StatusTextChanged);
			newBrowser.Navigated += new WebBrowserNavigatedEventHandler(webBrowser_Navigated);
			newBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(webBrowser_ProgressChanged);
			newBrowser.NewWindow += new CancelEventHandler(webBrowser_NewWindow);


			//ブラウザコントロールをタブページに追加
			newPage.Controls.Add(newBrowser);

			//タブページ追加
			this.tabControl1.TabPages.Add(newPage);

			this.tabControl1.SelectedTab = newPage;

			//初期表示HPへナビゲート
			this.Navigate(url);

			newBrowser.Focus();
		}

		#endregion

		#region ダイアログ関連

		/// <summary>
		/// ブックマークタイトル編集ダイアログ表示
		/// </summary>
		/// <param name="title">タイトル</param>
		private DialogResult ShowBookmarkEditor(string title)
		{
			var dlg = new BookmarkTitleEditor();

			dlg.MainDisplay = this;
			dlg.BookmarkTitle = title;

			return dlg.ShowDialog();
		}

		#endregion

		#region ブックマーク関連

		/// <summary>
		/// ブックマーク初期化
		/// </summary>
		private void InitializeBookmarkMenu()
		{
			var table = new DataTable();

			table = SqliteCommander.Select(Sql.GetBookmarks);

			foreach (DataRow row in table.Rows)
			{
				this.AddBookmarkMenu(row["name"].ToString(), row["url"].ToString());
			}
		}

		/// <summary>
		/// ブックマークメニュー追加
		/// </summary>
		/// <param name="title">ブックマークタイトル</param>
		/// <param name="url">URL</param>
		private void AddBookmarkMenu(string title, string url)
		{
			//ドロップダウンメニューアイテム追加
			var item = new ToolStripMenuItem(title);

			item.Click += new EventHandler(this.BookmarkTitle_Click);
			item.MouseUp += new MouseEventHandler(this.BookmarkDelete_MouseUp);

			this.menuBookmark.DropDownItems.Add(item);
			this._innerBookmarks.Add(new Bookmark(title, url));
		}

		#endregion

		#endregion
	}
}

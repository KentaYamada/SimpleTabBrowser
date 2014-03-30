namespace SimpleTabBrowser.Components
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSaveAsName = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuSettingPage = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPreview = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBookmark = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAddBookmark = new System.Windows.Forms.ToolStripMenuItem();
			this.オプションOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHomepageOption = new System.Windows.Forms.ToolStripMenuItem();
			this.menuClearUrl = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.menuVersion = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnGoBack = new System.Windows.Forms.ToolStripButton();
			this.btnGoForward = new System.Windows.Forms.ToolStripButton();
			this.btnReflesh = new System.Windows.Forms.ToolStripButton();
			this.btnHome = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txtCurrentUrl = new System.Windows.Forms.ToolStripTextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AddTabPage = new System.Windows.Forms.ToolStripMenuItem();
			this.DelTabPage = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.deleteBookmark = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.menuBookmark,
            this.オプションOToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1008, 26);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ファイルFToolStripMenuItem
			// 
			this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.menuSaveAsName,
            this.toolStripSeparator1,
            this.menuSettingPage,
            this.menuPrint,
            this.menuPreview,
            this.toolStripSeparator2,
            this.menuExit});
			this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
			this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
			this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
			// 
			// menuFileOpen
			// 
			this.menuFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuFileOpen.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.menuFileOpen.Name = "menuFileOpen";
			this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.menuFileOpen.Size = new System.Drawing.Size(237, 22);
			this.menuFileOpen.Text = "開く(&O)";
			this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
			// 
			// menuSaveAsName
			// 
			this.menuSaveAsName.Name = "menuSaveAsName";
			this.menuSaveAsName.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.menuSaveAsName.Size = new System.Drawing.Size(237, 22);
			this.menuSaveAsName.Text = "名前をつけて保存(&A)";
			this.menuSaveAsName.Click += new System.EventHandler(this.menuSaveAsName_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
			// 
			// menuSettingPage
			// 
			this.menuSettingPage.Name = "menuSettingPage";
			this.menuSettingPage.Size = new System.Drawing.Size(237, 22);
			this.menuSettingPage.Text = "ページ設定(&U)";
			this.menuSettingPage.Click += new System.EventHandler(this.menuSettingPage_Click);
			// 
			// menuPrint
			// 
			this.menuPrint.Name = "menuPrint";
			this.menuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.menuPrint.Size = new System.Drawing.Size(237, 22);
			this.menuPrint.Text = "印刷(&P)";
			this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
			// 
			// menuPreview
			// 
			this.menuPreview.Name = "menuPreview";
			this.menuPreview.Size = new System.Drawing.Size(237, 22);
			this.menuPreview.Text = "印刷プレビュー(&V)";
			this.menuPreview.Click += new System.EventHandler(this.menuPreview_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(234, 6);
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(237, 22);
			this.menuExit.Text = "終了(X)";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// menuBookmark
			// 
			this.menuBookmark.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddBookmark});
			this.menuBookmark.Name = "menuBookmark";
			this.menuBookmark.Size = new System.Drawing.Size(110, 22);
			this.menuBookmark.Text = "ブックマーク(&B)";
			// 
			// menuAddBookmark
			// 
			this.menuAddBookmark.Name = "menuAddBookmark";
			this.menuAddBookmark.Size = new System.Drawing.Size(202, 22);
			this.menuAddBookmark.Text = "ブックマークの追加(&A)";
			this.menuAddBookmark.Click += new System.EventHandler(this.menuAddBookmark_Click);
			// 
			// オプションOToolStripMenuItem
			// 
			this.オプションOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHomepageOption,
            this.menuClearUrl,
            this.toolStripSeparator3,
            this.menuVersion});
			this.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem";
			this.オプションOToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.オプションOToolStripMenuItem.Text = "オプション(&O)";
			// 
			// menuHomepageOption
			// 
			this.menuHomepageOption.Name = "menuHomepageOption";
			this.menuHomepageOption.Size = new System.Drawing.Size(191, 22);
			this.menuHomepageOption.Text = "ホームページ設定(&H)";
			this.menuHomepageOption.Click += new System.EventHandler(this.menuHomepageOption_Click);
			// 
			// menuClearUrl
			// 
			this.menuClearUrl.Name = "menuClearUrl";
			this.menuClearUrl.Size = new System.Drawing.Size(191, 22);
			this.menuClearUrl.Text = "URL履歴のクリア(&C)";
			this.menuClearUrl.Visible = false;
			this.menuClearUrl.Click += new System.EventHandler(this.menuClearUrl_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
			// 
			// menuVersion
			// 
			this.menuVersion.Name = "menuVersion";
			this.menuVersion.Size = new System.Drawing.Size(191, 22);
			this.menuVersion.Text = "バージョン情報(&V)";
			this.menuVersion.Click += new System.EventHandler(this.menuVersion_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGoBack,
            this.btnGoForward,
            this.btnReflesh,
            this.btnHome,
            this.toolStripLabel1,
            this.txtCurrentUrl});
			this.toolStrip1.Location = new System.Drawing.Point(0, 26);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1008, 27);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnGoBack
			// 
			this.btnGoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
			this.btnGoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnGoBack.Name = "btnGoBack";
			this.btnGoBack.Size = new System.Drawing.Size(24, 24);
			this.btnGoBack.Text = "←";
			this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
			// 
			// btnGoForward
			// 
			this.btnGoForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnGoForward.Image = ((System.Drawing.Image)(resources.GetObject("btnGoForward.Image")));
			this.btnGoForward.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnGoForward.Name = "btnGoForward";
			this.btnGoForward.Size = new System.Drawing.Size(24, 24);
			this.btnGoForward.Text = "→";
			this.btnGoForward.Click += new System.EventHandler(this.btnGoForward_Click);
			// 
			// btnReflesh
			// 
			this.btnReflesh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnReflesh.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnReflesh.Image = ((System.Drawing.Image)(resources.GetObject("btnReflesh.Image")));
			this.btnReflesh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnReflesh.Name = "btnReflesh";
			this.btnReflesh.Size = new System.Drawing.Size(26, 24);
			this.btnReflesh.Text = "！";
			this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
			// 
			// btnHome
			// 
			this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(47, 24);
			this.btnHome.Text = "Home";
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(37, 24);
			this.toolStripLabel1.Text = "URL:";
			// 
			// txtCurrentUrl
			// 
			this.txtCurrentUrl.AutoSize = false;
			this.txtCurrentUrl.Name = "txtCurrentUrl";
			this.txtCurrentUrl.Size = new System.Drawing.Size(100, 27);
			this.txtCurrentUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrentUrl_KeyDown);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ProgressBar});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 707);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1008, 23);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
			// 
			// ProgressBar
			// 
			this.ProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(100, 17);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.webBrowser1);
			this.tabPage1.Location = new System.Drawing.Point(4, 23);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1000, 627);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// webBrowser1
			// 
			this.webBrowser1.ContextMenuStrip = this.contextMenuStrip1;
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 3);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScriptErrorsSuppressed = true;
			this.webBrowser1.Size = new System.Drawing.Size(994, 621);
			this.webBrowser1.TabIndex = 0;
			this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
			this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
			this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser_NewWindow);
			this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser_ProgressChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTabPage,
            this.DelTabPage});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
			// 
			// AddTabPage
			// 
			this.AddTabPage.Name = "AddTabPage";
			this.AddTabPage.Size = new System.Drawing.Size(136, 22);
			this.AddTabPage.Text = "タブの追加";
			this.AddTabPage.Click += new System.EventHandler(this.AddTabPage_Click);
			// 
			// DelTabPage
			// 
			this.DelTabPage.Name = "DelTabPage";
			this.DelTabPage.Size = new System.Drawing.Size(136, 22);
			this.DelTabPage.Text = "タブの削除";
			this.DelTabPage.Click += new System.EventHandler(this.DelTabPage_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 53);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1008, 654);
			this.tabControl1.TabIndex = 3;
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteBookmark});
			this.contextMenuStrip2.Name = "contextMenuStrip1";
			this.contextMenuStrip2.Size = new System.Drawing.Size(185, 26);
			// 
			// deleteBookmark
			// 
			this.deleteBookmark.Name = "deleteBookmark";
			this.deleteBookmark.Size = new System.Drawing.Size(184, 22);
			this.deleteBookmark.Text = "ブックマークの削除";
			this.deleteBookmark.Click += new System.EventHandler(this.deleteBookmark_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "うぇぶぶらうざv2";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuBookmark;
		private System.Windows.Forms.ToolStripMenuItem オプションOToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnGoBack;
		private System.Windows.Forms.ToolStripButton btnGoForward;
		private System.Windows.Forms.ToolStripButton btnHome;
		private System.Windows.Forms.ToolStripButton btnReflesh;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar ProgressBar;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
		private System.Windows.Forms.ToolStripMenuItem menuSaveAsName;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuSettingPage;
		private System.Windows.Forms.ToolStripMenuItem menuPrint;
		private System.Windows.Forms.ToolStripMenuItem menuPreview;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem menuExit;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem AddTabPage;
		private System.Windows.Forms.ToolStripMenuItem DelTabPage;
		private System.Windows.Forms.ToolStripMenuItem menuAddBookmark;
		private System.Windows.Forms.ToolStripMenuItem menuHomepageOption;
		private System.Windows.Forms.ToolStripMenuItem menuClearUrl;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem menuVersion;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem deleteBookmark;
		private System.Windows.Forms.ToolStripTextBox txtCurrentUrl;
	}
}


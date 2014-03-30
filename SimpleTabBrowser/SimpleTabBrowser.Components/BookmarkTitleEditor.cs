using System;
using System.Windows.Forms;

namespace SimpleTabBrowser.Components
{
	/// <summary>
	/// ブックマークタイトル編集ダイアログ
	/// </summary>
	public partial class BookmarkTitleEditor : Form
	{
		#region Fields
		
		/// <summary>親フォーム</summary>
		public MainForm MainDisplay { private get; set; }

		/// <summary>ブックマークタイトル</summary>
		public string BookmarkTitle { private get; set; }

		#endregion

		#region Constructors

		public BookmarkTitleEditor()
		{
			InitializeComponent();
		}

		#endregion

		#region Events

		/// <summary>
		/// 起動イベント
		/// </summary>
		private void BookmarkTitleEditor_Load(object sender, EventArgs e)
		{
			this.txtBookmarkTitle.Text = this.BookmarkTitle;
		}
		
		/// <summary>
		/// 「OK」クリック
		/// </summary>
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(this.txtBookmarkTitle.Text))
			{
				this.errorProvider1.SetError(this.txtBookmarkTitle, "タイトルを入力してください。");
				this.txtBookmarkTitle.Focus();

				return;
			}

			this.DialogResult = DialogResult.OK;
			this.MainDisplay.BookmarkTitle = this.txtBookmarkTitle.Text;

			this.Close();
			this.Dispose();
		}

		/// <summary>
		/// 「キャンセル」クリック
		/// </summary>
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;

			this.Close();
			this.Dispose();
		}

		#endregion
	}
}

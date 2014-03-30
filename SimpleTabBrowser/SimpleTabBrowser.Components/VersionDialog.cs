using System;
using System.Text;
using System.Windows.Forms;

namespace SimpleTabBrowser.Components
{
	/// <summary>
	/// バージョン情報ダイアログ
	/// </summary>
	public partial class VersionDialog : Form
	{
		public VersionDialog()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 起動時イベント
		/// </summary>
		private void Version_Load(object sender, EventArgs e)
		{
			var sb = new StringBuilder();

			sb.AppendLine("うぇぶぶらうざ v2");
			sb.AppendLine("ver 1.0.0.0");
			sb.AppendLine("Copyright © Kenta Yamada 2013");
			sb.AppendLine("All Rights Reserved.");

			this.label1.Text = sb.ToString();
		}

		/// <summary>
		/// 「OK」クリック
		/// </summary>
		private void btnOK_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
		}
	}
}

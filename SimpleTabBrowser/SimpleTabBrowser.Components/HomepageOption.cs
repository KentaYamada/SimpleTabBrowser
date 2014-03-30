using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

using KntLibrary.DAO.Sqlite;

namespace SimpleTabBrowser.Components
{
	/// <summary>
	/// スタートアップページ設定ダイアログ
	/// </summary>
	/// <author>Yamada Kenta</author>
	public partial class HomepageOption : Form
	{
		#region Fields

		/// <summary>GoogleURL</summary>
		private const string _Google = "https://www.google.co.jp/";

		/// <summary>YahooURL</summary>
		private const string _Yahoo = "http://www.yahoo.co.jp/";

		#endregion

		#region Constructors
		
		public HomepageOption()
		{
			InitializeComponent();
		}

		#endregion

		#region Events

		/// <summary>
		/// 起動時イベント
		/// </summary>
		private void HomepageOption_Load(object sender, EventArgs e)
		{
			var table = new DataTable();

			try
			{
				table = SqliteCommander.Select(Sql.GetStartupSql);
			}
			catch
			{
				MessageBox.Show("アプリケーションエラーが発生しました。");
				this.Close();
				this.Dispose();
				Application.Exit();
			}

			if (0 < table.Rows.Count)
			{
				this.Initialize(table.Rows[0]);
			}
		}

		/// <summary>
		/// 「その他」値変更イベント
		/// </summary>
		private void rdoOther_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rdoOther.Checked)
			{
				this.txtURL.Enabled = true;
				this.txtTitle.Enabled = true;
			}
			else
			{
				this.txtURL.Enabled = false;
				this.txtTitle.Enabled = false;
			}
		}

		/// <summary>
		/// 「OK」クリック
		/// </summary>
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (!this.InputCheck())
			{
				return;
			}

			try
			{
				this.UpdateStartUpPage();
			}
			catch
			{
				MessageBox.Show("アプリケーションエラーが発生しました。");
				this.Close();
				this.Dispose();
				Application.Exit();
			}
			
			this.Close();
			this.Dispose();
		}

		/// <summary>
		/// 「キャンセル」クリック
		/// </summary>
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// 初期化設定
		/// </summary>
		private void Initialize(DataRow row)
		{
			this.errorProvider1.Clear();

			this.rdoGoogle.Checked = false;
			this.rdoYahoo.Checked = false;
			this.rdoOther.Checked = true;

			this.txtURL.Text = Convert.ToString(row["url"]);
			this.txtTitle.Text = Convert.ToString(row["name"]);
			this.txtURL.Focus();
		}

		/// <summary>
		/// 入力チェック
		/// </summary>
		/// <returns>True:正常 / False:エラー</returns>
		private bool InputCheck()
		{
			this.errorProvider1.Clear();

			if (!this.rdoOther.Checked)
			{
				return true;
			}

			bool result = true;

			var target = (from x in this.panel1.Controls.OfType<TextBox>()
						  where x.Text == string.Empty
						  orderby x.TabIndex
						  select x).ToArray();

			if (0 < target.Length)
			{
				this.errorProvider1.SetError(target[0] ,"必須入力です。");
				target[0].Focus();
				result = false;
			}

			return result;
		}

		/// <summary>
		/// スタートアップページ更新
		/// </summary>
		private void UpdateStartUpPage()
		{
			string sql = string.Empty;

			if (this.rdoYahoo.Checked)
			{
				sql = Sql.SaveStartUpSql(_Yahoo, "Yahoo!");
			}
			else if (this.rdoGoogle.Checked)
			{
				sql = Sql.SaveStartUpSql(_Google, "Google");
			}
			else
			{
				sql = Sql.SaveStartUpSql(this.txtURL.Text, this.txtTitle.Text);
			}

			try
			{
				SqliteCommander.Save(sql);
			}
			catch
			{
				throw;
			}
		}

		#endregion
	}
}

using System;
using System.Data;
using System.Windows.Forms;

using KntLibrary.DAO.Sqlite;
using SimpleTabBrowser.Components;

namespace SimpleTabBrowser
{
	static class Program
	{
		/// <summary>
		/// Main entry point
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//Get start up page
			var table = new DataTable();

			try
			{
				table = SqliteCommander.Select(Sql.GetStartupSql);
			}
			catch 
			{
				MessageBox.Show("アプリケーションエラー発生したため終了します。");
				Application.Exit();
			}

			var form = new MainForm();
			form.DefaultHomePage = table.Rows[0]["url"].ToString();

			Application.Run(form);
		}
	}
}

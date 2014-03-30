using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTabBrowser.Components
{
	/// <summary>
	/// SQL文字列クラス
	/// </summary>
	public static class Sql
	{
		public static readonly string GetStartupSql = "select name, url from Bookmark where Bookmark.no = 0;";

		public static readonly string DeleteBookmarksSql = "delete from Bookmark where 0 < no;";

		public static string GetBookmarks
		{
			get
			{
				var sql = new StringBuilder();

				sql.Length = 0;
				sql.AppendLine("select");
				sql.AppendLine(" name");
				sql.AppendLine(",url");
				sql.AppendLine("from Bookmark");
				sql.AppendLine("where");
				sql.AppendLine("0 < Bookmark.no;");

				return sql.ToString();
			}
		}

		public static string SaveStartUpSql(string defaultUrl, string title)
		{
			var sql = new StringBuilder();

				sql.Length = 0;
				sql.AppendLine("update Bookmark set");
				sql.AppendLine(" name = " + string.Format("'{0}'", title));
				sql.AppendLine(",url = " + string.Format("'{0}'", defaultUrl));
				sql.AppendLine(",upddate = " + string.Format("'{0}'", DateTime.Now.ToString("yyyy/MM/dd")));
				sql.AppendLine("where Bookmark.no = 0;");

				return sql.ToString();
		}

		public static List<string> InsertBookmarksSql(List<Bookmark> bookmarks)
		{
			var list = new List<string>();
			var sql = new StringBuilder();
			int i = 1;

			foreach (Bookmark b in bookmarks)
			{
				sql.Length = 0;
				sql.AppendLine("insert into Bookmark(");
				sql.AppendLine("  no");
				sql.AppendLine(" ,name");
				sql.AppendLine(" ,url");
				sql.AppendLine(" ,upddate");
				sql.AppendLine(") values (");
				sql.AppendLine(i.ToString());
				sql.AppendLine(string.Format(",'{0}'", b.Title));
				sql.AppendLine(string.Format(",'{0}'", b.Url));
				sql.AppendLine(string.Format(",'{0}'", DateTime.Now.ToString("yyyy/MM/dd")));
				sql.AppendLine(");");

				list.Add(sql.ToString());
			}

			return list;
		}
	}
}

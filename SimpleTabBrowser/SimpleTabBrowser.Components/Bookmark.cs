using System;

namespace SimpleTabBrowser.Components
{
	/// <summary>
	/// Webページ情報格納クラス
	/// </summary>
	public class Bookmark
	{
		public Bookmark()
		{ }

		public Bookmark(string title, string url)
		{
			this.Title = title;
			this.Url = url;
		}

		/// <summary>アクセス日時</summary>
		public DateTime Accessed { get; set; }

		/// <summary>ＵＲＬ</summary>
		public string Url { get; set; }

		/// <summary>タイトル</summary>
		public string Title { get; set; }
	}
}


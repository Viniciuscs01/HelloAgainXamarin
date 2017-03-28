using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using HelloWorld2.Droid;
using HelloWorld2.Persistence;

[assembly: Dependency(typeof(SQLiteDb))]

namespace HelloWorld2.Droid
{
	public class SQLiteDb : ISQLiteDb
	{
		public SQLiteAsyncConnection GetConnection()
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var path = Path.Combine(documentsPath, "MySQLite.db3");

			return new SQLiteAsyncConnection(path);
		}
	}
}


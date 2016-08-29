using System;
using SQLite;

namespace GoodReads
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}


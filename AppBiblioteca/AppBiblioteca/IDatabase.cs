using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppBiblioteca
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();
    }
}

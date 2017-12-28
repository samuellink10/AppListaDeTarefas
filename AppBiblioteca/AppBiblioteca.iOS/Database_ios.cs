using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AppBiblioteca.iOS;
using Foundation;
using SQLite;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(Database_ios))]
namespace AppBiblioteca.iOS
{
    public class Database_ios : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            try
            {
                string nomeDB = "biblioteca.db3";
                string folder = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),"..","Libary");
                var caminhoDB = Path.Combine(folder, nomeDB);
                return new SQLiteConnection(caminhoDB);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
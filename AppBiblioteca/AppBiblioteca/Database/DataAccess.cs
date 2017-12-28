using AppBiblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
using AppBiblioteca.Models;
using System.Linq;

namespace AppBiblioteca.Database
{
    public class DataAccess 
    {
        private static SQLiteConnection _instance;

        public DataAccess()
        {
            _instance = DependencyService.Get<IDatabase>().GetConnection();
            _instance.CreateTable<Tarefa>();
        }

        public int Delete(Tarefa t) => _instance.Delete(t);

        public List<Tarefa> GetAll() => _instance.Table<Tarefa>().ToList();

        public Tarefa GetSingle(int id) => _instance.Table<Tarefa>().Single(x=> x.Id == id);

        public int Update(Tarefa t) => _instance.Update(t);

        public int Insert(Tarefa t) => _instance.Insert(t);
    }
}

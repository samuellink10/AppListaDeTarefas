using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace AppBiblioteca.Models
{
    [Table("Tarefa")]
   public class Tarefa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Finalizacao { get; set; }
    }
}

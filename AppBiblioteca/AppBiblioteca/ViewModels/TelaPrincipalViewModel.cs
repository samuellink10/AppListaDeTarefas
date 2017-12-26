using AppBiblioteca.Database;
using AppBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBiblioteca.ViewModels
{
   public  class TelaPrincipalViewModel
    {
        public List<Tarefa> Tarefas { get; set; }
        public TelaPrincipalViewModel()
        {
            Tarefas = new DataAccess().GetAll();
           // Tarefas.Add(new Tarefa{Id=1,Nome="Task 01",Finalizacao = false });

        }
    }
}

using AppBiblioteca.Database;
using AppBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AppBiblioteca.ViewModels
{
   public  class TelaPrincipalViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Tarefa> Tarefas { get; set; }
        public Tarefa TarefaAtual { get; set; }
        public Command SalvarCommand { get; set; }
        public Command EditarCommand { get; set; }
        public Command ExcluirCommand { get; set; }
        public Command ModificarCommand { get; set; }
        public TelaPrincipalViewModel()
        {
            Tarefas = new ObservableCollection<Tarefa>(new DataAccess().GetAll());
            TarefaAtual = new Tarefa();
            SalvarCommand = new Command(Salvar);
            EditarCommand = new Command<Tarefa>(Editar);
            ExcluirCommand = new Command<Tarefa>(Excluir);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string p = null) { }

        public void Salvar()
        {
            if (TarefaAtual.Id == 0) {
                TarefaAtual.Finalizacao = false;
                new DataAccess().Insert(TarefaAtual);

                Tarefas.Add(TarefaAtual);
             

                TarefaAtual = new Tarefa();
                OnPropertyChanged("TarefaAtual");
            }else
            {
                new DataAccess().Update(TarefaAtual);
                Tarefas = new ObservableCollection<Tarefa>(new DataAccess().GetAll());
                OnPropertyChanged("Tarefa");
                TarefaAtual = new Tarefa();
                OnPropertyChanged("TarefaAtual");
            }

        }
        public void Editar(Tarefa t)
        {
            TarefaAtual = t;
            OnPropertyChanged("TarefaAtual");
        }
        public void Excluir(Tarefa t)
        {
            new DataAccess().Delete(t);
            Tarefas.Remove(t);
        }
    }
}

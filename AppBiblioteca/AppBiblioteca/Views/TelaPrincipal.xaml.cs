using AppBiblioteca.Database;
using AppBiblioteca.Models;
using AppBiblioteca.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBiblioteca.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaPrincipal : ContentPage
    {
        private Tarefa TarefaEdicao { get; set; }
        public TelaPrincipal()
        {
            InitializeComponent();
            BindingContext = new TelaPrincipalViewModel();

            //btnSave.Clicked += delegate {
            //    if (TarefaEdicao == null)
            //    {
            //        Tarefa t = new Tarefa() { Nome = txtTask.Text, Finalizacao = false };
            //        new DataAccess().Insert(t);
            //        txtTask.Text = "";
            //        txtTask.Focus();
            //        BindingContext = new TelaPrincipalViewModel();
            //    }
            //    else
            //    {
            //        TarefaEdicao.Nome = txtTask.Text;
            //        new DataAccess().Update(TarefaEdicao);
            //        txtTask.Text = "";
            //        txtTask.Focus();
            //        BindingContext = new TelaPrincipalViewModel();
            //        TarefaEdicao = null;
            //    }
            //};
        }

        public void ExcluirTask(Object sender, EventArgs e)
        {
            var t = (((MenuItem)sender).CommandParameter) as Tarefa;
            new DataAccess().Delete(t.Id);
            BindingContext = new TelaPrincipalViewModel();
        }
        //public void EditarTask(Object sender, EventArgs e)
        //{
        //    var t = (((MenuItem)sender).CommandParameter) as Tarefa;
        //    txtTask.Text = t.Nome;
        //    TarefaEdicao = t;
        //}
        public void FinalizarTask(object sender, EventArgs e)
        {
            var t = ((Button)sender).CommandParameter as Tarefa;
            if (t.Finalizacao == true)
                t.Finalizacao = false;     
            else
                t.Finalizacao = true;

            new DataAccess().Update(t);
            BindingContext = new TelaPrincipalViewModel();
        }

    }
}
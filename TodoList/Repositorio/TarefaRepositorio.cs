using System;
using System.Collections.Generic;
using System.IO;
using TodoList.ViewModel;

namespace TodoList.Repositorio
{
    public class TarefaRepositorio
    {
        // static List<TarefaViewModel> listaDeTarefas = new List<TarefaViewModel>();
        static int cont = 0;
        public TarefaViewModel Inserir(TarefaViewModel tarefa){
            List<TarefaViewModel> listaDeTarefas = Listar();
            int contador = 0;
            if (listaDeTarefas != null){
                contador = listaDeTarefas.Count + cont;
            }

            tarefa.Id = contador + 1;
            tarefa.DataCriacao = DateTime.Now;

            StreamWriter sw = new StreamWriter("tarefas.csv",true);
            sw.WriteLine($"{tarefa.Id};{tarefa.Nome};{tarefa.Descricao};{tarefa.Tipo};{tarefa.IdUsuario};{tarefa.DataCriacao}");
            sw.Close();
            return tarefa;
        }

        public List<TarefaViewModel> Listar(){
            List<TarefaViewModel> listaDeTarefas = new List<TarefaViewModel>();
            TarefaViewModel tarefaViewModel;
            if (!File.Exists("tarefas.csv")){
                return null;
            }

            string[] tarefas = File.ReadAllLines("tarefas.csv");

            foreach (var item in tarefas){
                if (item != null){
                    string[] dadoDeCadaTarefa = item.Split(";");
                    tarefaViewModel = new TarefaViewModel();
                    tarefaViewModel.Id = int.Parse(dadoDeCadaTarefa[0]);
                    tarefaViewModel.Nome = dadoDeCadaTarefa[1];
                    tarefaViewModel.Descricao = dadoDeCadaTarefa[2];
                    tarefaViewModel.Tipo = dadoDeCadaTarefa[3];
                    tarefaViewModel.IdUsuario = int.Parse(dadoDeCadaTarefa[4]);
                    tarefaViewModel.DataCriacao = DateTime.Parse(dadoDeCadaTarefa[5]);

                    listaDeTarefas.Add(tarefaViewModel);
                }
            }
           return listaDeTarefas;
        }

        public void Deletar(string nomeRecuperado){
            List<string> listaDeTarefas= new List<string>(); 
            nomeRecuperado += ";";

            string[] seila = File.ReadAllLines("tarefas.csv");

            foreach (var item in seila){
                if (!item.Contains(nomeRecuperado)){
                    // System.Console.WriteLine(i);
                    listaDeTarefas.Add(item);
                }
                // System.Console.WriteLine(item);
            }
            File.Delete("tarefas.csv");
            StreamWriter sw = new StreamWriter("tarefas.csv",true);

            foreach (var item in listaDeTarefas){
                sw.WriteLine(item);
                // System.Console.WriteLine(item);
            }
            sw.Close();
            cont++;

            System.Console.WriteLine("Item Removido com sucesso!");
                
        }

    }
}
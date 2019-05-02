using System;
using System.Collections.Generic;
using TodoList.ViewModel;

namespace TodoList.Repositorio
{
    public class TarefaRepositorio
    {
        static List<TarefaViewModel> listaDeTarefas = new List<TarefaViewModel>();

        public TarefaViewModel Inserir(TarefaViewModel tarefa){
            tarefa.Id = listaDeTarefas.Count + 1;
            tarefa.DataCriacao = DateTime.Now;

            listaDeTarefas.Add(tarefa);
            return tarefa;
        }

        public List<TarefaViewModel> Listar(){
           return listaDeTarefas;
        }
    }
}
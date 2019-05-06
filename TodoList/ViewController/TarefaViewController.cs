using System;
using System.Collections.Generic;
using TodoList.Repositorio;
using TodoList.ViewModel;

namespace TodoList.ViewController
{
    public class TarefaViewController
    {
        static TarefaRepositorio tarefaRepositorio = new TarefaRepositorio();
        public static void CriarTarefa(int idUser){
            string nome, descricao, tipo;
            int numTipo;

            do{
                System.Console.WriteLine("Insira o Nome da Tarefa");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome Inválido");
                }
            } while (string.IsNullOrEmpty(nome));
            do{
                System.Console.WriteLine("Insira uma Descrição à Tarefa");
                descricao = Console.ReadLine();
                if (string.IsNullOrEmpty(descricao)){
                    System.Console.WriteLine("Descrição Inválida");
                }
            } while (string.IsNullOrEmpty(descricao));
            do{
                System.Console.WriteLine("--Insira o Tipo de Tarefa--");
                System.Console.WriteLine("1 - Para Fazer");
                System.Console.WriteLine("2 - Fazendo");
                System.Console.WriteLine("3 - Feito");
                numTipo = int.Parse(Console.ReadLine());
                switch (numTipo){
                    case 1:
                        tipo = "Para Fazer";
                        break;
                    case 2:
                        tipo = "Fazendo";
                        break;
                    case 3:
                        tipo = "Feito";
                        break;
                    default:
                        System.Console.WriteLine("Valor Inválido");
                        tipo = null;
                    break;
                }
            } while (tipo == null);
            
            TarefaViewModel tarefaViewModel = new TarefaViewModel();
            tarefaViewModel.Nome = nome;
            tarefaViewModel.Tipo = tipo;
            tarefaViewModel.Descricao = descricao;
            tarefaViewModel.IdUsuario = idUser;

            tarefaRepositorio.Inserir(tarefaViewModel);


        }

        public static void DeletarTarefas(){
            List<TarefaViewModel> listaDeTarefas = tarefaRepositorio.Listar();
            System.Console.WriteLine("Digite o Nome da tarefa que deseja remover:");
            string deletar = Console.ReadLine();
            TarefaViewModel tarefaRecuperada = null;
            foreach (var item in listaDeTarefas){
                if (item != null && item.Nome == deletar){
                    tarefaRecuperada = item;
                }
            }
            if (tarefaRecuperada != null){
                // System.Console.WriteLine($"Item a ser deletado: {tarefaRecuperada.Id} {tarefaRecuperada.Nome}");
                tarefaRepositorio.Deletar(tarefaRecuperada.Nome);
            }
        }

    /// <summary>Listar tarefas feito pelo Raul</summary>
        public static void ListarTarefas(int idRecuperado){
            List<TarefaViewModel> listaDeTarefas = tarefaRepositorio.Listar();
            foreach (var item in listaDeTarefas){
                if (item.IdUsuario == idRecuperado){
                    System.Console.WriteLine($"-- -- --\nID: {item.Id} - Nome: {item.Nome}\nDescrição: {item.Descricao} - Data Criaçao: {item.DataCriacao}\nTipo: {item.Tipo} - Criador da Tarefa: {item.IdUsuario}");
                    
                }
            }
        }
    }
}
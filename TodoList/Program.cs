using System;
using TodoList.Utils;
using TodoList.ViewController;
using TodoList.ViewModel;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta = 0;

            do{
 
                resposta = MenuUtils.MenuNovo();
                    
                switch (resposta)
                {
                    case 1://Criar conta
                        UsuarioViewController.CriarConta();
                        ContinuarUtil.Continuar();
                    break;

                    case 2://Logar
                        UsuarioViewModel userRecuperado = UsuarioViewController.Logar();
                        if (userRecuperado != null){
                            #region LOGADO
                            System.Console.WriteLine("Login efetuado com sucesso");
                            do{
                                MenuUtils.MenuLogado();
                                resposta = int.Parse(Console.ReadLine()); 

                                switch (resposta)
                                {
                                    case 1://Criar tarefa
                                        TarefaViewController.CriarTarefa(userRecuperado.Id);
                                        ContinuarUtil.Continuar();

                                    break;
                                    
                                    case 2://Listar tarefas
                                        TarefaViewController.ListarTarefas(userRecuperado.Id);
                                        ContinuarUtil.Continuar();

                                    break;

                                    case 3:
                                        TarefaViewController.DeletarTarefas();
                                        ContinuarUtil.Continuar();
                                    break;

                                    case 9:
                                    break;

                                    default:
                                        System.Console.WriteLine("Valor inserido inválido");
                                    break;
                                }
                            } while (resposta != 9);
                        }
                            #endregion
                    break;
                    
                    case 3://Listar users???
                        UsuarioViewController.Listar();
                        ContinuarUtil.Continuar();
                    break;

                    case 0:
                    break;

                    default:
                        System.Console.WriteLine("Valor inserido inválido");
                    break;
                }

            }while(resposta !=0);

        
        
        }
    }
}

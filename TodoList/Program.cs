using System;
using TodoList.Utils;
using TodoList.ViewController;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta = 0;

            do{
                MenuUtils.MenuUser(); 
                
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1://Criar conta
                        UsuarioViewController.CriarConta();
                    break;

                    case 2://Logar
                        int idRecuperado = UsuarioViewController.Logar();
                        if (idRecuperado != 0){
                            System.Console.WriteLine("Login efetuado com sucesso");
                            do{
                                MenuUtils.MenuLogado();
                                resposta = int.Parse(Console.ReadLine()); 

                                switch (resposta)
                                {
                                    case 1://Criar tarefa
                                        TarefaViewController.CriarTarefa(idRecuperado);
                                    break;
                                    
                                    case 2://Listar tarefas
                                        TarefaViewController.ListarTarefas(idRecuperado);
                                    break;

                                    case 9:
                                    break;

                                    default:
                                        System.Console.WriteLine("Valor inserido inválido");
                                    break;
                                }
                                System.Console.WriteLine("\nPressione ENTER para continuar");
                                Console.ReadLine();
                            } while (resposta != 9);
                        }
                            
                    break;
                    
                    case 3://Listar users???
                        UsuarioViewController.Listar();
                    break;
                    default:
                        System.Console.WriteLine("Valor inserido inválido");
                    break;
                }

                System.Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadLine();
            }while(resposta !=0);

        
        
        }
    }
}

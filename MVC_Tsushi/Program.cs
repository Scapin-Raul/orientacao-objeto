using System;
using MVC_Tsushi.ViewModel;
using MVC_Tsushi.Utils;
using MVC_Tsushi.ViewController;

namespace MVC_Tsushi
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            int opcaoLogado = 0;
            do{
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());
                
                switch (opcaoDeslogado)
                {
                    case 1: //CADASTRO USER
                        UsuarioViewController.CadastrarUsuario();
                    break;
                    case 2: //EFETUAR LOGIN
                        UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfeturLogin();
                        if (usuarioRecuperado != null){
                            System.Console.WriteLine($"Seja bem-vindo {usuarioRecuperado.Nome}");    
                            Console.ReadLine();
#region LOGADO
                            do{
                                MenuUtil.MenuLogado();
                                opcaoLogado = int.Parse(Console.ReadLine());
                                switch (opcaoLogado){

                                    case 1:// Cadastrar produto
                                        ProdutoViewController.CadastrarProduto();
                                    break;
                                    
                                    case 2://Listar
                                        ProdutoViewController.ListarProduto();
                                    break;
                                    
                                    case 3://Buscar por ID
                                        ProdutoViewController.BuscarId();
                                    break;

                                    case 0://Sair
                                        System.Console.WriteLine("Obrigado pela visita!");
                                    break;
                                    
                                    default:
                                        System.Console.WriteLine("Opção inválida");
                                    break;
                                }
                            } while (opcaoLogado != 0);
#endregion
                        }
                    break;

                    case 3: //LISTAR
                        UsuarioViewController.ListarUsuario();
                    break;

                    case 0: //SAIR
                        System.Console.WriteLine("Obrigado pela Visita!");
                    break;
                    
                    default: //OPÇÃO INVALIDA
                        System.Console.WriteLine("Opçao Inválida!");
                    break;
                }
                
            } while (opcaoDeslogado != 0);



        }
    }
}

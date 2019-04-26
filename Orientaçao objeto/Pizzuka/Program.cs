using System;

namespace Pizzuka
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Bem vindo(a) a Pizzuka");
           int escolha = 0;
           do
           {
               Console.WriteLine("1 -- Cadastrar usuario");
               Console.WriteLine("2 -- Login");
               Console.WriteLine("3 -- Listar usuaário");
               Console.WriteLine("9 -- Sair");
               escolha = int.Parse(Console.ReadLine());

               switch(escolha){
                   case 1:
                       Usuario2.Inserir();
                   break;
                   case 2:
                        Usuario2.EfetuarLogin();
                        int escolha2 = 0;
                        do{
                            Console.WriteLine("\n1 -- Cadastrar produto");
                            Console.WriteLine("2 -- Listar produtos");
                            Console.WriteLine("3 -- Busca por ID");
                            Console.WriteLine("9 -- Fazer Logout");
                            escolha2 = int.Parse(Console.ReadLine());
                            switch(escolha2){
                                case 1: //Cadastrar produto
                                    Produtos.Cadastrar();
                                break;

                                case 2: //Listar produtos
                                    Produtos.Listar();
                                break;

                                case 3: //Busca por ID
                                    Produtos.Buscar();
                                break;
                            }

                        } while (escolha2 != 9);
                   break;
                   case 3:
                       Usuario2.Listar();
                   break;
                   case 9:

                   break;
                   default:
                       Console.WriteLine("Valor inválido");
                   break;
               }
           } while (escolha != 9);
       }
   }
}
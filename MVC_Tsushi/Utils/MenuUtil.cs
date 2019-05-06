using System;
namespace MVC_Tsushi.Utils
{
    public class MenuUtil
    {
        /// <summary>EXIBE AS OPÇÕES DO USUÁRIO DESLOGADO</summary>
        public static void MenuDeslogado(){
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine(" ________________________");
            System.Console.WriteLine("|         TSUSHI         |");
            System.Console.WriteLine("|------------------------|");
            System.Console.WriteLine("|- 1 CADASTRAR USUARIO --|");
            System.Console.WriteLine("|- 2 EFETUAR LOGIN ------|");
            System.Console.WriteLine("|- 3 LISTAR -------------|");
            System.Console.WriteLine("|- 0 SAIR ---------------|");
            System.Console.WriteLine("|------------------------|");
            System.Console.WriteLine("|__ ESCOLHA UMA OPÇÃO: __|");
            Console.ResetColor ();
        }//FIM MENU DESLOGADO

        public static void MenuLogado(){
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine(" ________________________");
            System.Console.WriteLine("|    TSUSHI - CARDAPIO   |");
            System.Console.WriteLine("|------------------------|");
            System.Console.WriteLine("|- 1 CADASTRAR PRODUTO --|");
            System.Console.WriteLine("|- 2 LISTAR -------------|");
            System.Console.WriteLine("|- 3 BUSCAR POR ID ------|");
            System.Console.WriteLine("|- 0 DESLOGAR -----------|");
            System.Console.WriteLine("|------------------------|");
            System.Console.WriteLine("|__ ESCOLHA UMA OPÇÃO: __|");
            Console.ResetColor ();

        }
    
    }
}
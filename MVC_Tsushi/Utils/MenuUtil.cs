using System;
namespace MVC_Tsushi.Utils
{
    public class MenuUtil
    {
        /// <summary>EXIBE AS OPÇÕES DO USUÁRIO DESLOGADO</summary>
        public static void MenuDeslogado(){
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("----------TSUSHI----------");
            System.Console.WriteLine("-- 1 CADASTRAR USUARIO ---");
            System.Console.WriteLine("-- 2 EFETUAR LOGIN -------");
            System.Console.WriteLine("-- 3 LISTAR --------------");
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("-- 0 SAIR ----------------");
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("--- ESCOLHA UMA OPÇÃO: ---");
            Console.ResetColor ();
        }//FIM MENU DESLOGADO
    }
}
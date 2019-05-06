using System;

namespace MVC_Tsushi.Utils
{
    public class ContinuarUtils
    {
        static public void Continuar(){

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("\nPressione ENTER para voltar ao menu!");
            System.Console.ReadLine();
            Console.ResetColor();
        }
    }
}
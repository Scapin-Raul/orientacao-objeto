using System;

namespace TodoList.Utils
{
    public class ContinuarUtil
    {
        static public void Continuar(){
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("\nPressione ENTER para voltar ao menu!");
            System.Console.ReadLine();
            Console.ResetColor();
        }
    }
}
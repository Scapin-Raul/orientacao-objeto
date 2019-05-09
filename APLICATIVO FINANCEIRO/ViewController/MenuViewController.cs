using System;

namespace APLICATIVO_FINANCEIRO.ViewController
{
    public class MenuViewController
    {
        public static void DestacarOpcao(string opcao) {
                Console.BackgroundColor = ConsoleColor.Blue;
                System.Console.WriteLine(opcao);
                Console.ResetColor();
        }
                
        public static string TratarTituloMenu(string titulo) {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace ("_", " ").ToLower ());
        }
    }
}
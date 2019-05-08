using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Model
{
    public class Teclado : Lixo, IIndefinido
    {
        public void Cinza()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            System.Console.WriteLine($"{this.GetType().Name} deve ser jogado no lixo Cinza!");
            Console.ResetColor();        
        }
    }
}
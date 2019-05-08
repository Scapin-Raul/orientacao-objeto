using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Model
{
    public class EmbalagemMetalica : Lixo, IMetal
    {
        public void Amarelo()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{this.GetType().Name} deve ser jogado no lixo Amarelo!");
            Console.ResetColor();
        }
    }
}
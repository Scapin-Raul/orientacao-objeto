using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Model
{
    public class Sacola : Lixo, IPlastico
    {
        public void Vermelho()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"{this.GetType().Name} deve ser jogado no lixo Vermelho!");
            Console.ResetColor();
        }
    }
}
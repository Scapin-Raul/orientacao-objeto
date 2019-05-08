using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Model
{
    public class FolhaDePapel : Lixo, IPapel
    {
        public void Azul()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.WriteLine($"{this.GetType().Name} deve ser jogado no lixo Azul!");
            Console.ResetColor();
        }
    }
}
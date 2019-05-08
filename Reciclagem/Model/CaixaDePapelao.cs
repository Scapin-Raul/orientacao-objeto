using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Model
{
    public class CaixaDePapelao : Lixo, IPapel
    {
        public void Azul()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.WriteLine($"{this.GetType().Name} deve ser jogado no lixo AZUL!");
            Console.ResetColor();

        }
    }
}
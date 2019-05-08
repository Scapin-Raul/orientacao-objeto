using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Model
{
    public class GarrafaVidro : Lixo, IVidro
    {
        public void Verde()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"{this.GetType().Name} deve ser jogado no lixo Verde!");
            Console.ResetColor();
        }
    }
}
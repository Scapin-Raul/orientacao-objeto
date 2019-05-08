using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Model
{
    public class CascaDeBanana : Lixo, IOrganico
    {
        public void Preto()
        {               
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine($"{this.GetType().Name} deve ser jogado no lixo Preto ou levado à uma Composteira!");
            Console.ResetColor();

        }
    }   
}
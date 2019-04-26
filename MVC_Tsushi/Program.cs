using System;
using MVC_Tsushi.ViewModel;
using MVC_Tsushi.Utils;

namespace MVC_Tsushi
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            do{
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());
                
                switch (opcaoDeslogado)
                {
                    case 1: //CADASTRO USER

                    break;
                    case 2: //EFETUAR LOGIN

                    break;

                    case 3: //LISTAR

                    break;

                    case 0: //SAIR

                    break;
                    
                    default: //OPÇÃO INVALIDA
                    break;
                }
                
            } while (opcaoDeslogado != 0);



        }
    }
}

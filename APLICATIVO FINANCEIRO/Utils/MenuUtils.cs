using System;
using System.Collections.Generic;
using APLICATIVO_FINANCEIRO.ViewController;
using static APLICATIVO_FINANCEIRO.Enuns.MenuDeslogado;

namespace APLICATIVO_FINANCEIRO.Utils
{
    public class MenuUtils
    {
        static public int MenuDeslogado(){
            string[] itensMenuPrincipal = Enum.GetNames (typeof (MenuSemLogin));

            var opcoes = new List<string>()
                                    {   "    - 0                  ",
                                        "    - 1                        ",
                                        "    - 2              ",
                                        "    - 3                         "};

            int opcoesSelecionada = 0;

            string menuBar = "===================================";

                do {
                    Console.Clear ();

                    System.Console.WriteLine (menuBar);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine (" Seja bem-vindo(a) APP Financeiro! ");
                    System.Console.WriteLine ("                           MobTec  ");
                    System.Console.WriteLine ("        Escolha uma opção:         ");
                    Console.ResetColor ();
                    System.Console.WriteLine (menuBar);
                    
                    for (int i = 0; i < opcoes.Count; i++)
                    {
                        string titulo = MenuViewController.TratarTituloMenu(itensMenuPrincipal[i]);

                        if (opcoesSelecionada == i) {
                            MenuViewController.DestacarOpcao(opcoes[opcoesSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
                        } else {
                            System.Console.WriteLine(opcoes[i].Replace(i.ToString(), titulo));
                        }
                    }
                
                    var key = Console.ReadKey(true).Key;

                    switch(key) {
                        case ConsoleKey.UpArrow:
                            opcoesSelecionada = opcoesSelecionada == 0 ? opcoesSelecionada : --opcoesSelecionada;
                            
                        break;
                        case ConsoleKey.DownArrow:
                            opcoesSelecionada = opcoesSelecionada == opcoes.Count - 1 ? opcoesSelecionada : ++opcoesSelecionada;
                            
                        break;
                        case ConsoleKey.Enter:
                            return opcoesSelecionada;
                    }
        }while (true);
    }
        static public int MenuLogado(string nomeUser){
            string[] itensMenuPrincipal = Enum.GetNames (typeof (MenuComLogin));

            var opcoes = new List<string>()
                                    {   "    - 0          ",
                                        "    - 1               ",
                                        "    - 2                    ",
                                        "    - 3      ",
                                        "    - 4                         "};

            int opcoesSelecionada = 0;

            string menuBar = "===================================";

                do {
                    Console.Clear ();

                    System.Console.WriteLine ($" Seja bem-vindo(a) {nomeUser}! ");
                    System.Console.WriteLine (menuBar);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine ("       Controle de Financias       ");
                    System.Console.WriteLine ("                           MobTec  ");
                    System.Console.WriteLine ("        Escolha uma opção:         ");
                    Console.ResetColor ();
                    System.Console.WriteLine (menuBar);
                    
                    for (int i = 0; i < opcoes.Count; i++)
                    {
                        string titulo = MenuViewController.TratarTituloMenu(itensMenuPrincipal[i]);

                        if (opcoesSelecionada == i) {
                            MenuViewController.DestacarOpcao(opcoes[opcoesSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
                        } else {
                            System.Console.WriteLine(opcoes[i].Replace(i.ToString(), titulo));
                        }
                    }
                
                    var key = Console.ReadKey(true).Key;

                    switch(key) {
                        case ConsoleKey.UpArrow:
                            opcoesSelecionada = opcoesSelecionada == 0 ? opcoesSelecionada : --opcoesSelecionada;
                            
                        break;
                        case ConsoleKey.DownArrow:
                            opcoesSelecionada = opcoesSelecionada == opcoes.Count - 1 ? opcoesSelecionada : ++opcoesSelecionada;
                            
                        break;
                        case ConsoleKey.Enter:
                            return opcoesSelecionada;
                    }
        }while (true);
    }
}
}
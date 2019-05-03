using System;
using System.Collections.Generic;

namespace menuzika
{
    class Program
    {
        enum FormacaoEnum : uint{
            KKKKKKKKK_K,
            JJJJJ_KKK,
            LSDASADDSA,
        };
        static void Main(string[] args)
        {
             bool querSair = false;
    string[] itensMenuPrincipal = Enum.GetNames (typeof (FormacaoEnum));

    var opcoesFormacao = new List<string>()
                                {"    - 0                  ",
                                 "    - 1                    ",
                                 "    - 2                   "};

    int opcaoFormacaoSelecionada = 0;

    string menuBar = "===================================";

    do {
        bool formacaoEscolhida = false;

        do {
            Console.Clear ();

            System.Console.WriteLine (menuBar);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine ("     Seja bem-vindo(a) Vocal!      ");
            System.Console.WriteLine ("        Escolha uma formação:      ");
            Console.ResetColor ();
            System.Console.WriteLine (menuBar);
            
            for (int i = 0; i < opcoesFormacao.Count; i++)
            {
                string titulo = TratarTituloMenu(itensMenuPrincipal[i]);

                if (opcaoFormacaoSelecionada == i) {
                    DestacarOpcao(opcoesFormacao[opcaoFormacaoSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
                } else {
                    System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
                }
            }
           
            var key = Console.ReadKey(true).Key;

            switch(key) {
                case ConsoleKey.UpArrow:
                    opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                    
                break;
                case ConsoleKey.DownArrow:
                    opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcaoFormacaoSelecionada : ++opcaoFormacaoSelecionada;
                    
                break;
                case ConsoleKey.Enter:
                    formacaoEscolhida = true;
                    break;
            }

        } while(!formacaoEscolhida);
        
    } while(!querSair);
                
                



        }
    public static void DestacarOpcao(string opcao) {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        System.Console.WriteLine(opcao);
        Console.ResetColor();
    }
        
    public static string TratarTituloMenu(string titulo) {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace ("_", " ").ToLower ());
    }
    }
}

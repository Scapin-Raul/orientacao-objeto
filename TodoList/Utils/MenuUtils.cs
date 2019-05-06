using System;
using System.Collections.Generic;

namespace TodoList.Utils
{
    public class MenuUtils
    {
        enum FormacaoEnum : uint{
            CRIAR_CONTA = 1,
            LOGAR,
            LISTAR_USUARIOS,
            SAIR,
        };
        public static void MenuUser(){
            System.Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            System.Console.WriteLine("------------Menu------------");
            System.Console.WriteLine("1- Criar conta              ");
            System.Console.WriteLine("2- Logar                    ");
            System.Console.WriteLine("3- Listar usuários          ");
            System.Console.WriteLine("0- Sair                     ");
            System.Console.WriteLine("                            ");

            Console.ResetColor();
        }    

        public static void MenuLogado(){
            System.Console.Clear();
            System.Console.WriteLine("---Gerenciador de Tarefas---");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            System.Console.WriteLine("1- Criar Tarefa             ");
            System.Console.WriteLine("2- Listar Tarefas           ");
            System.Console.WriteLine("3- Deletar Tarefa           ");
            System.Console.WriteLine("9- Deslogar                 ");
            Console.ResetColor();
            System.Console.WriteLine("                            ");
        }


        public static int MenuNovo(){
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames (typeof (FormacaoEnum));

            var opcoesFormacao = new List<string>()
                                    {   "    - 0                  ",
                                        "    - 1                        ",
                                        "    - 2              ",
                                        "    - 3                         "};

            int opcaoFormacaoSelecionada = 0;

            string menuBar = "===================================";

            do {
                bool formacaoEscolhida = false;

                do {
                    Console.Clear ();

                    System.Console.WriteLine (menuBar);
                    // Console.BackgroundColor = ConsoleColor.DarkCyan;
                    // Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine ("         Seja bem-vindo(a)         ");
                    System.Console.WriteLine ("     ao Gerenciado de Tarefas!     ");
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
                switch (opcaoFormacaoSelecionada){
                    case 0:
                        return 1;

                    case 1:
                        return 2;
                    
                    case 2: 
                        return 3;
                    
                    case 3:
                        return 0;
                    
                }
            } while(!querSair);
                    return 0;    
                }
        
        public static void DestacarOpcao(string opcao) {
                // Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                System.Console.WriteLine(opcao);
                Console.ResetColor();
            }
                
            public static string TratarTituloMenu(string titulo) {
                return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace ("_", " ").ToLower ());
            }

        
    }
}
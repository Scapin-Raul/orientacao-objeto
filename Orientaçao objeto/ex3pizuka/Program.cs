using System;

namespace ex3pizuka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("---Bem vindo à Pizzaria do Tsukamoto!---");
            Console.ResetColor();            
            bool sair = false;
            Usuario[] usuarios = new Usuario[5];
            int contasCriadas = 0;
            do{
                System.Console.WriteLine("\n------Menu------\n| 1 - Cadastrar usuários\n| 2 - Efetuar login\n| 3 - Listar usuários\n| 9 - Sair");                
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1://cadastrar usuários
                        Usuario u = new Usuario();

                        System.Console.WriteLine("Insira o nome:");
                        string nome = Console.ReadLine();
                        
                        string email;
                        do{
                            System.Console.WriteLine("Insira o email:");
                            email = Console.ReadLine();
                            if (email.IndexOf("@") >=0){
                                System.Console.WriteLine("tem @");
                            } else{
                                System.Console.WriteLine("O email deve conter @ e .");
                            }
                        } while (email.IndexOf("@") <=0 || email.IndexOf(".") <=0);
                        
                        System.Console.WriteLine("Insira o senha:");
                        string senha = Console.ReadLine();
                        contasCriadas++;
                        u.Criacao(nome,email,senha,contasCriadas);

                        
                    break;

                    case 2://efetuar login
                    
                    break;
                    
                    case 3://listar usuários
                    
                    break;

                    case 9: //sair
                        System.Console.WriteLine("Obrigado pela atenção...");
                        sair = true;
                    break;
                } //fim switch
            } while (!sair);
        }
    }
}

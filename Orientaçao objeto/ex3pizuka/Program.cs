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
            int cont = 1;
            do{
                System.Console.WriteLine("\n------Menu------\n| 1 - Cadastrar usuários\n| 2 - Efetuar login\n| 3 - Listar usuários\n| 9 - Sair");                
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1://cadastrar usuários
                        System.Console.Write("Insira o nome: ");
                        string nome = Console.ReadLine();
                        
                        string email;
                        do{
                            System.Console.Write("Insira o email: ");
                            email = Console.ReadLine();
                            if (email.IndexOf("@") <=0 || email.IndexOf(".") <=0){
                                System.Console.WriteLine("O email deve conter @ e .");
                            }
                        } while (email.IndexOf("@") <=0 || email.IndexOf(".") <=0);

                        string senha;
                        do{
                            System.Console.Write("Insira o senha: ");
                            senha = Console.ReadLine();
                            if (senha.Length < 6){
                                System.Console.WriteLine("A senha deve conter mais de 6 caracteres");
                            }
                        } while (senha.Length < 6);

                        Console.ForegroundColor = ConsoleColor.Green;
                        usuarios[contasCriadas].Inserir(nome,email,senha,cont);
                        Console.ResetColor ();

                        contasCriadas++;
                        cont++;
                    break;

                    case 2://efetuar login
                        System.Console.WriteLine("---Área de Login---");
                        System.Console.Write("Digite o e-mail: ");
                        string emailUser = Console.ReadLine();
                        Usuario userRecuperado = null;
                        foreach (Usuario item in usuarios)
                        {
                            if (item != null && emailUser.Equals(item.email)) {
                                userRecuperado = item;
                                break;
                            }
                        }
                        if (userRecuperado == null){
                            System.Console.WriteLine("E-mail não cadastrado.");
                            continue;
                        }
                        
                        System.Console.Write("Digite a senha: ");
                        string senhaUser = Console.ReadLine();

                        userRecuperado.EfetuarLogin(senhaUser);
                        Console.ResetColor ();


                    break;
                    
                    case 3://listar usuários
                        int cont3 =0;
                        foreach (Usuario item in usuarios){
                            if (item == null){
                                break;
                            }else{
                                cont3++;
                                item.Listar(cont3);
                            }
                        }
                    break;

                    case 9: //sair
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Obrigado pela atenção...");
                        Console.ResetColor();
                        sair = true;
                    break;
                } //fim switch
            } while (!sair);
        }
    }
}

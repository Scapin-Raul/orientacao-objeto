using System;
using APLICATIVO_FINANCEIRO.Repositorio;
using APLICATIVO_FINANCEIRO.Utils;
using APLICATIVO_FINANCEIRO.ViewModel;

namespace APLICATIVO_FINANCEIRO.ViewController
{
    public class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public static void CriarUsuario()
        {
            Console.Clear();
            System.Console.WriteLine("Cadastro de Usuário:");
            string nome;
            
            do{
                System.Console.Write("Nome de Usuário: ");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome) || nome.Length < 3){
                    System.Console.WriteLine("Nome Inválido");
                }    
            } while (string.IsNullOrEmpty(nome) || nome.Length < 3);
            string email;
            
            do{
                System.Console.WriteLine("-----------------------------");
                System.Console.Write("Email do Usuário: ");
                email = Console.ReadLine();
                if (!email.Contains("@") || !email.Contains(".")){
                    System.Console.WriteLine("O email deve conter @ e .");
                }            
            } while (!email.Contains("@") || !email.Contains("."));
            
            string senha;
            string confirmaSenha;
            do{
                do
                {
                    System.Console.WriteLine("-----------------------------");
                    System.Console.Write("Senha do Usuário: ");
                    senha = Console.ReadLine();
                    if (senha.Length < 6){
                        System.Console.WriteLine("A senha deve conter ao menos 6 caracteres!");
                    }
                } while (senha.Length < 6);

                System.Console.Write("Confirmação de senha do Usuário: ");
                confirmaSenha = Console.ReadLine();
                if (!senha.Equals(confirmaSenha)){
                    System.Console.WriteLine("As senhas não conferem.\nReiniciando registro de senha.");
                }

            } while (!senha.Equals(confirmaSenha));
            
            DateTime dataNascimento;
            do{
                System.Console.WriteLine("-----------------------------");
                System.Console.Write("Data de Nascimento do Usuário: ");
                dataNascimento = DateTime.Parse(Console.ReadLine());
            } while (dataNascimento == null);

            var usuario = new UsuarioViewModel();
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataNascimento = dataNascimento;

            usuarioRepositorio.Inserir(usuario);
            System.Console.WriteLine("Usuário cadastrado com sucesso!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1111!!");
            ContinuarUtils.Continuar();

        }

        internal static UsuarioViewModel EfetuarLogin()
        {
            Console.Clear();
            System.Console.WriteLine("----Efetuar Login----");
            System.Console.Write("Insira o Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Insira a Senha: ");
            string senha = Console.ReadLine();
            var listaDeUsuarios = usuarioRepositorio.Listar();
                foreach (var item in listaDeUsuarios)
                {
                    if (item.Email.Equals(email) && item.Senha.Equals(senha))
                    {
                        Console.WriteLine("Login realizado com sucesso!");
            ContinuarUtils.Continuar();

                        return item;                        
                    }
                }
            ContinuarUtils.Continuar();

                return null;
        }   

        public static void ListarUsuarios()
        {
            var listaDeUsuarios = usuarioRepositorio.Listar();
            Console.Clear();
            
            foreach (var item in listaDeUsuarios){
                System.Console.WriteLine($"------------ID: {item.Id}------------\n| Nome: {item.Nome}\n| Email: {item.Email} \n| Data de Nascimento: {item.DataNascimento:dd/MMMM/yyyy}");
                System.Console.WriteLine("-----------------------------");
            }
            
            ContinuarUtils.Continuar();
        }
    }
}
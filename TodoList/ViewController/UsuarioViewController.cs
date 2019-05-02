using System;
using System.Collections.Generic;
using TodoList.Repositorio;
using TodoList.Utils;
using TodoList.ViewModel;

namespace TodoList.ViewController
{
    public class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public static void CriarConta(){
            string nome, email, senha, tipo;
            int numTipo;
            do{
                System.Console.WriteLine("Insira o Nome de Usuário");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome Inválido");
                }
            } while (string.IsNullOrEmpty(nome));
            do{
                System.Console.WriteLine("Insira o E-mail do Usuário");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email)){
                    System.Console.WriteLine("O email deve conter @ e .");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));
            do{
                System.Console.WriteLine("Insira a Senha do Usuário");
                senha = Console.ReadLine();
                if (!ValidacaoUtil.ValidarSenha(senha)){
                    System.Console.WriteLine("A senha deve conter ao menos 6 caracteres");
                }
            } while (!ValidacaoUtil.ValidarSenha(senha));
            do{
                System.Console.WriteLine("--Insira o Tipo de Conta--");
                System.Console.WriteLine("1 - Usuário");
                System.Console.WriteLine("2 - Admin");
                numTipo = int.Parse(Console.ReadLine());
                switch (numTipo){
                    case 1:
                        tipo = "User";
                    break;

                    case 2:
                        tipo = "Admin";
                    break;
                    default:
                        System.Console.WriteLine("Valor Inválido");
                        tipo = null;
                    break;
                }
            } while (tipo == null);


            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.Tipo = tipo;

            usuarioRepositorio.Inserir(usuarioViewModel);
            System.Console.WriteLine("Cadastro efetuado com sucesso!");
        }

        public static void Listar(){
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();
            foreach (var item in listaDeUsuarios){   
                System.Console.WriteLine($"-- -- --\nID: {item.Id} - Nome: {item.Nome}\nEmail: {item.Email} - Data Criaçao: {item.DataCriacao}\n Tipo: {item.Tipo}");
            }
        }

        public static int Logar(){
            System.Console.Write("Insira o email: ");
            string email = Console.ReadLine();    
            System.Console.Write("Insira a senha: ");
            string senha = Console.ReadLine();    

            UsuarioViewModel usuarioRecuperado = UsuarioRepositorio.BuscarUsuario(email, senha);

            if (usuarioRecuperado != null){
                return usuarioRecuperado.Id;
                // return usuarioRecuperado;
            }else{
                System.Console.WriteLine("Email ou senha inválidos");
                return 0;
                // return null;
            }
        
        }
    }
}
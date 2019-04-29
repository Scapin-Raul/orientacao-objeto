using System;
using System.Collections.Generic;
using MVC_Tsushi.Repositorio;
using MVC_Tsushi.Utils;
using MVC_Tsushi.ViewModel;

namespace MVC_Tsushi.ViewController
{
    public class UsuarioViewController
    { 

        //Instanciar o repositório
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
#region CADASTRAR_USUARIO
        public static void CadastrarUsuario(){
            string nome, email, senha, confirmaSenha;
            do{
                System.Console.WriteLine("Digite o Nome de Usuário");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome inválido");
                }
            } while (string.IsNullOrEmpty(nome));
            do{
                System.Console.WriteLine("Digite o E-mail do Usuário");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email)){
                    System.Console.WriteLine("Email inválido, o email deve conter @ e .");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));
            do{
                System.Console.WriteLine("Digite a senha do Usuário");
                senha = Console.ReadLine();

                System.Console.WriteLine("Confirme a senha");
                confirmaSenha = Console.ReadLine();
                if (!ValidacaoUtil.ConfirmacaoSenha(senha, confirmaSenha)){
                    System.Console.WriteLine("As senhas devem ser iguais e conter mais de 5 caracteres");
                }
            } while (!ValidacaoUtil.ConfirmacaoSenha(senha,confirmaSenha));

            // cria um objeto do tipo usuario
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            
            
            // Metodo para inserir no banco de dados
            usuarioRepositorio.Inserir(usuarioViewModel);

            System.Console.WriteLine("Cadastro efetuado com sucesso!");

        }//fim cadastrar
#endregion
#region LISTAR_USUARIO
        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();
            foreach (var item in listaDeUsuarios){
                System.Console.WriteLine($"ID: {item.Id} - Nome: {item.Nome} - Email: {item.Email} - Senha: {item.Senha} - Data Criaçao: {item.DataCriacao}");
            }
        }
#endregion 
#region EFETUAR_LOGIN 
        public static UsuarioViewModel EfeturLogin(){
            string email, senha;
            do{
                System.Console.Write("Insira o email: ");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email)){
                    System.Console.WriteLine("Email inválido!!!!");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));
            System.Console.Write("Insira a senha: ");
            senha = Console.ReadLine();
            
            UsuarioViewModel usuarioRecuperado = UsuarioRepositorio.BuscarUsuario(email, senha);
            if (usuarioRecuperado != null){
                return usuarioRecuperado;
            }else{
                System.Console.WriteLine("Email ou senha inválidos");
                return null;
            }
        }
#endregion
    }
}
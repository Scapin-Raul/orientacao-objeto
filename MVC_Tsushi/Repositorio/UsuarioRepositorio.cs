using System;
using System.Collections.Generic;
using System.IO;
using MVC_Tsushi.ViewModel;

namespace MVC_Tsushi.Repositorio
{
    public class UsuarioRepositorio
    {   
        // static int cont = 0;
        // static List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
        /// <summary>METODO RESPONSAVEL POR ARMAZENAR UM USUARIO</summary>
    public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            int contador = 0;
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            if (listaDeUsuarios != null){
                contador = listaDeUsuarios.Count;
            }

            usuario.Id = contador + 1;
            usuario.DataCriacao = DateTime.Now;

            StreamWriter sw = new StreamWriter("usuarios.csv",true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao};");
            sw.Close();

            return usuario;
        }

        /// <summary>RETORNA LISTA DE USUARIOS</summary>
        public List<UsuarioViewModel> Listar(){
            List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
            UsuarioViewModel usuarioViewModel;
            if (!File.Exists("usuarios.csv")){
                return null;
            }

            string[] usuarios = File.ReadAllLines("usuarios.csv");

            foreach (var item in usuarios){
                if (item != null){
                    
                    string[] dadosDeCadaUsuario = item.Split(";");
                    usuarioViewModel = new UsuarioViewModel();
                    usuarioViewModel.Id = int.Parse(dadosDeCadaUsuario[0]);
                    usuarioViewModel.Nome = dadosDeCadaUsuario[1];
                    usuarioViewModel.Email = dadosDeCadaUsuario[2];
                    usuarioViewModel.Senha = dadosDeCadaUsuario[3];
                    usuarioViewModel.DataCriacao = DateTime.Parse(dadosDeCadaUsuario[4]);

                    // System.Console.WriteLine(listaDeUsuarios.Count);
                    listaDeUsuarios.Add(usuarioViewModel);
                }
            }
            return listaDeUsuarios;
        }

        /// <summary>VERIFICA SE O USUARIO É VALIDO</summary>
        /// <param name="email">Email do usuário</param>
        /// <param name="senha">Senha do Usuário</param>
        /// <returns>Retorna o usuário caso ele seja encontrado ou null caso não encontre</returns>
        public UsuarioViewModel BuscarUsuario(string email, string senha){
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            foreach (var item in listaDeUsuarios){
                if (item.Email.Equals(email) && item.Senha.Equals(senha)){
                    return item;
                }
            }
            return null;
        }


    }
}
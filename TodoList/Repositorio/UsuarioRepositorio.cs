using System;
using System.Collections.Generic;
using System.IO;
using TodoList.ViewModel;

namespace TodoList.Repositorio
{
    public class UsuarioRepositorio
    {
        // static List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();

        /// <summary>Metodo responsavel por armazenar um usuário</summary>
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            int contador = 0;
            if (listaDeUsuarios != null){
                contador = listaDeUsuarios.Count;
            }
            
            usuario.Id = contador + 1;
            usuario.DataCriacao = DateTime.Now;

            StreamWriter sw = new StreamWriter("usuarios.csv",true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.Tipo};{usuario.DataCriacao};");
            sw.Close();
            return usuario;
        }

        public UsuarioViewModel BuscarUsuario(string email, string senha)
        {
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            foreach (var item in listaDeUsuarios){
                if (item.Email.Equals(email) && item.Senha.Equals(senha)){
                    return item;
                }
            }
            return null;   
        }

        public List<UsuarioViewModel> Listar()
        {
            List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
            UsuarioViewModel usuarioViewModel;
            if (!File.Exists("usuarios.csv")){
                return null;
            }

            string[] usuarios = File.ReadAllLines("usuarios.csv");

            foreach (var item in usuarios){
                if (item != null){
                    string[] dadoDeCadaUsuarios = item.Split(";");
                    usuarioViewModel = new UsuarioViewModel();
                    usuarioViewModel.Id = int.Parse(dadoDeCadaUsuarios[0]);
                    usuarioViewModel.Nome = dadoDeCadaUsuarios[1];
                    usuarioViewModel.Email = dadoDeCadaUsuarios[2];
                    usuarioViewModel.Senha = dadoDeCadaUsuarios[3];
                    usuarioViewModel.Tipo = dadoDeCadaUsuarios[4];
                    usuarioViewModel.DataCriacao = DateTime.Parse(dadoDeCadaUsuarios[5]);

                    listaDeUsuarios.Add(usuarioViewModel);
                }
            }
            return listaDeUsuarios;
        }
    }
}
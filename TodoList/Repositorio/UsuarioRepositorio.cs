using System;
using System.Collections.Generic;
using TodoList.ViewModel;

namespace TodoList.Repositorio
{
    public class UsuarioRepositorio
    {
        static List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();

        /// <summary>Metodo responsavel por armazenar um usuário</summary>
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            usuario.Id = listaDeUsuarios.Count + 1;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add(usuario);
            return usuario;
        }

        public static UsuarioViewModel BuscarUsuario(string email, string senha)
        {
            foreach (var item in listaDeUsuarios){
                if (item.Email.Equals(email) && item.Senha.Equals(senha))
                {
                    return item;
                }
            }
            return null;   
        }

        public List<UsuarioViewModel> Listar()
        {
            return listaDeUsuarios;
        }
    }
}
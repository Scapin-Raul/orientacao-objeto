using System;
using System.Collections.Generic;
using MVC_Tsushi.ViewModel;

namespace MVC_Tsushi.Repositorio
{
    public class UsuarioRepositorio
    {
        static List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
        /// <summary>METODO RESPONSAVEL POR ARMAZENAR UM USUARIO</summary>
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            usuario.Id = listaDeUsuarios.Count + 1;
            usuario.DataCriacao = DateTime.Now;

            //insere o obj usuario na lista
            listaDeUsuarios.Add(usuario);
            return usuario;
        }

        /// <summary>RETORNA LISTA DE USUARIOS</summary>
        public List<UsuarioViewModel> Listar(){
            return listaDeUsuarios;
        }

        /// <summary>VERIFICA SE O USUARIO É VALIDO</summary>
        /// <param name="email">Email do usuário</param>
        /// <param name="senha">Senha do Usuário</param>
        /// <returns>Retorna o usuário caso ele seja encontrado ou null caso não</returns>
        public static UsuarioViewModel BuscarUsuario(string email, string senha){
            foreach (var item in listaDeUsuarios){
                if (item.Email.Equals(email) && item.Senha.Equals(senha)){
                    return item;
                }
            }
            return null;
        }


    }
}
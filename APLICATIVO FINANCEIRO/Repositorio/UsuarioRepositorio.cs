using System;
using APLICATIVO_FINANCEIRO.Utils;
using APLICATIVO_FINANCEIRO.ViewController;
using APLICATIVO_FINANCEIRO.ViewModel;
using System.IO;
using System.Collections.Generic;



namespace APLICATIVO_FINANCEIRO.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            int contador = 0;

            if (listaDeUsuarios != null){
                contador = listaDeUsuarios.Count;
            }
            
            usuario.Id = contador+1;

            StreamWriter sw = new StreamWriter("usuarios.csv",true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}");
            sw.Close();

            return usuario;
        }

        public List<UsuarioViewModel> Listar(){
            var listaDeUsuarios = new List<UsuarioViewModel>();
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
                    usuarioViewModel.DataNascimento = DateTime.Parse(dadosDeCadaUsuario[4]);

                    listaDeUsuarios.Add(usuarioViewModel);
                }
            }

            return listaDeUsuarios;

        }


    }
}
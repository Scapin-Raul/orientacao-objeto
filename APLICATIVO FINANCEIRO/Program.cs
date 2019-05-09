using System;
using APLICATIVO_FINANCEIRO.Utils;
using APLICATIVO_FINANCEIRO.ViewController;
using APLICATIVO_FINANCEIRO.ViewModel;

namespace APLICATIVO_FINANCEIRO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;

            do{
                int codigo = MenuUtils.MenuDeslogado();
                // System.Console.WriteLine(codigo);
                
                
                // Console.ReadLine();

                switch (codigo)
                {
                    case 0://CRIAR CONTA
                        UsuarioViewController.CriarUsuario();
                        break;
                    case 1://LOGAR
                        var usuarioRecuperado = UsuarioViewController.EfetuarLogin();
                        if (usuarioRecuperado == null){
                            break;
                        }
                        bool querSairLogado = false;
                        do{
                            int codigoLogado = MenuUtils.MenuLogado(usuarioRecuperado.Nome);
                            
                            switch (codigoLogado){
                                case 4:
                                    querSairLogado = true;
                                    break;

                                
                            }

                        } while (!querSairLogado);
                        break;
                    
                    case 2: //LISTAR USER
                        UsuarioViewController.ListarUsuarios();
                        break;
                    
                    case 3: //SAIR PRONTO
                        querSair = true;
                        break;
                }
            } while (!querSair);
        }
    }
}

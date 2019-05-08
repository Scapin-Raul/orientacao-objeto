using System;
using Reciclagem.Interfaces;
using Reciclagem.Model;

namespace Reciclagem
{
    enum TiposDeLixo : uint
    {
        SACOLA,
        CAIXA_DE_PAPELAO,
        GARRAFA_PET,
        GARRAFA_VIDRO,
        CASCA_DE_BANANA,
        FOLHA_DE_PAPEL,
        EMBALAGEM_METALICA,
        TECLADO,
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            int escolha =0;

            do{
                Console.Clear();
                ExibirMenu();
                System.Console.WriteLine("Digite o código de qual lixo deseja descartar:");
                escolha = int.Parse(Console.ReadLine());
                
                switch (escolha){
                    case 1:
                        var lixo = TodosLixos.TiposLixos[escolha];
                        ExibirMensagem((IPlastico)lixo);
                    break;
                    
                    case 2:
                        lixo = TodosLixos.TiposLixos[escolha];
                        ExibirMensagem((IPapel)lixo);
                    break;

                    case 3:
                        lixo = TodosLixos.TiposLixos[escolha];
                        ExibirMensagem((IPlastico)lixo);
                    break;
                    
                    case 4:
                        lixo = TodosLixos.TiposLixos[escolha];
                        ExibirMensagem((IVidro)lixo);
                    break;
                    
                    case 5:
                        lixo = TodosLixos.TiposLixos[escolha];
                        ExibirMensagem((IOrganico)lixo);
                    break;

                    case 6:
                        lixo = TodosLixos.TiposLixos[escolha];
                        ExibirMensagem((IPapel)lixo);
                    break;
                    
                    case 7:
                        lixo = TodosLixos.TiposLixos[escolha];
                        ExibirMensagem((IMetal)lixo);
                    break;

                    case 8:
                        lixo = TodosLixos.TiposLixos[escolha];
                        ExibirMensagem((IIndefinido)lixo);
                    break;
    
                }
                
            }while(!querSair);

        }

        public static string TratarTituloMenu (string titulo) {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());
        }
        public static void ExibirMenu () {
            Console.Clear();
            var lixos = Enum.GetNames (typeof (TiposDeLixo));
            int codigo = 1;
            string borda = "##############################";
            System.Console.WriteLine (borda);
            System.Console.WriteLine ("#         Tipos de Lixo        #");

            foreach (var lixo in lixos) 
            {
                System.Console.WriteLine ($"   {codigo++}. {TratarTituloMenu(lixo)}");
            }

            System.Console.WriteLine (borda);
        } 
        public static void Continuar(){
            System.Console.WriteLine("\nPara voltar ao menu pressione ENTER!");
            Console.ReadLine();
        }

        #region EXIBIR_MENSAGEM
        public static void ExibirMensagem(IPapel lixo){
            lixo.Azul();
            Continuar();
        }
        public static void ExibirMensagem(IMetal lixo){
            lixo.Amarelo();
            Continuar();
        }
        public static void ExibirMensagem(IOrganico lixo){
            lixo.Preto();
            Continuar();
        }
        public static void ExibirMensagem(IIndefinido lixo){
            lixo.Cinza();
            Continuar();
        }
        public static void ExibirMensagem(IPlastico lixo){
            lixo.Vermelho();
            Continuar();
        }
        public static void ExibirMensagem(IVidro lixo){
            lixo.Verde();
            Continuar();
        }
        #endregion
    
    }
}
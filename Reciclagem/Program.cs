using System;
using System.Linq;
using Reciclagem.Interfaces;
using Reciclagem.Model;

namespace Reciclagem
{
    enum TiposDeLixo : uint {
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
                if (escolha >= 1 && escolha <= 8)
                {
                    var lixo = TodosLixos.TiposLixos[escolha];
                    Reciclar(lixo);
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
            System.Console.WriteLine ("#        Tipos de Lixo       #");

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

        /// <summary>Modelo novo de exibir mensagem.</summary>
        public static void Reciclar(Lixo lixo){
            Type tipoLixo = lixo.GetType().GetInterfaces().FirstOrDefault();
        
            if (typeof(IPapel).Equals(tipoLixo)){
                var lixoConvertido = (IPapel) lixo;
                lixoConvertido.Azul();
                Continuar();
            }else if (typeof(IMetal).Equals(tipoLixo)){
                var lixoConvertido = (IMetal) lixo;
                lixoConvertido.Amarelo();
                Continuar();
            }
            else if (typeof(IOrganico).Equals(tipoLixo)){
                var lixoConvertido = (IOrganico) lixo;
                lixoConvertido.Preto();
                Continuar();
            }
            else if (typeof(IIndefinido).Equals(tipoLixo)){
                var lixoConvertido = (IIndefinido) lixo;
                lixoConvertido.Cinza();
                Continuar();
            }
            else if (typeof(IPlastico).Equals(tipoLixo)){
                var lixoConvertido = (IPlastico) lixo;
                lixoConvertido.Vermelho();
                Continuar();
            }
            else if (typeof(IVidro).Equals(tipoLixo)){
                var lixoConvertido = (IVidro) lixo;
                lixoConvertido.Verde();
                Continuar();
            }
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
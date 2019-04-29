namespace MVC_Tsushi.Utils
{
    public class ValidacaoUtil
    {
        /// <summary>RETORNA TRUE CASO O EMAIL CONTENHA @ E .</summary>
        public static bool ValidarEmail(string email){
            if (email.Contains("@") && email.Contains(".")){
                return true;
            }
            return false;
        }//fim validacao email

    /// <summary>RETORNA TRUE CASO AS SENHAS SEJAM IGUAIS E CONTENHA MAIS DE 5 CARACTERES. RETORNA FALSO PARA O CONTRÁRIO</summary>
        public static bool ConfirmacaoSenha(string senha, string confirmaSenha){
            if (senha.Equals(confirmaSenha)&& senha.Length >=6){
                return true;
            }
            return false;
        }//fim confirmacao senha
        
    }
}
namespace TodoList.Utils
{
    public class ValidacaoUtil
    {
        public static bool ValidarEmail(string email){
            if (email.Contains("@") && email.Contains(".")){
                return true;
            }
            return false;
        }
        public static bool ValidarSenha(string senha){
            if (senha.Length > 5){
                return true;
            }
            return false;
        }

    }
}
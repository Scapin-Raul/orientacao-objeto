namespace ex3pizuka
{
    using System;
    public class Usuario
    {
        public int id = 0;
        public string nome;
        public string email;
        private string senha;
        private DateTime dataCriacao;

        public string Inserir(string nome, string email, string senha, int cont){
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            dataCriacao = DateTime.Now;
            id = cont;
            return "Usuario criado com sucesso.";
        }
        public string Listar(int cont3){
            string mensagem ="";
            mensagem+="-----Usuário "+cont3+"---\nNome do usuário: "+nome+"\nE-mail: "+email+"\nId: "+id+"\n";
            return mensagem;
        }
        public string EfetuarLogin(string senhaUser){
            if(senhaUser == senha){
                Console.ForegroundColor = ConsoleColor.Green;
                return $"Bem-vindo - {nome}";
            }else{
                Console.ForegroundColor = ConsoleColor.DarkRed;
                return "Senha inválida.";
            }
        }
    }
}
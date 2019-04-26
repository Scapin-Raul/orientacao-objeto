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

        public void Inserir(string nome, string email, string senha, int cont){
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            dataCriacao = DateTime.Now;
            id = cont;
            System.Console.WriteLine("Usuario criado com sucesso.");
        }
        public void Listar(int cont3){
            string mensagem ="";
            mensagem+="-----Usuário "+cont3+"---\nNome do usuário: "+nome+"\nE-mail: "+email+"\nId: "+id+"\n";
            System.Console.WriteLine(mensagem);
            return;
        }
        public void EfetuarLogin(string senhaUser){
            if(senhaUser == senha){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"Bem-vindo - {nome}");
                return;
            }else{
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine("Senha inválida.");
            }
        }
    }
}
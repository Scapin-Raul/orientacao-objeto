namespace ex3pizuka
{
    using System;
    public class Usuario
    {
        public int id;
        public string nome;
        public string email;
        private string senha;
        public DateTime dataCriacao;

        public string Criacao(string nome, string email, string senha, int cont){
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            id = cont;
            return "Usuario criado com sucesso.";
        }


    }
}
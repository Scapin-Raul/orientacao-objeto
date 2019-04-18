namespace ex2Senaizinho
{
using System;

    public class Sala
    {
        public int numeroSala = 0;
        public int capacidadeAtual;
        public int capacidadeTotal;
        public string[] alunos;
        public int cont = 0;
        
        public string setAlunos(string valor){
            this.alunos[cont] = valor;
            cont++;
            capacidadeAtual--;
            return "Aluno alocado com sucesso.";
        }
        public string removerAlunos(){
            cont--;
            capacidadeAtual++;
            return "Aluno removido com sucesso.";
        }
        public string exibirAlunos(){
            string mensagem = "";
            for (int j = 0; j < cont; j++){
                if (alunos[j] != null)
                {   
                    if (j == (cont - 1)){
                        mensagem += $"{alunos[j]}.";
                    }else{
                        mensagem += $"{alunos[j]}, ";
                    }
                }
            }
            return mensagem;
        }

    }
}
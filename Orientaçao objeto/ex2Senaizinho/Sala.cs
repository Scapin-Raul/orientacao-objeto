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
        
        public void setAlunos(string valor){
            this.alunos[cont] = valor;
            cont++;
        }
        // public bool getAlunos(){
        //     for (int i = 0; i < cont; i++){
        //         return true;
        //         System.Console.WriteLine(alunos[i]);
        //     }
        //     return false;
        // }

    }
}
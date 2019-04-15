namespace ex2Senaizinho
{
    public class Sala
    {
        public int numeroSala;
        public int capacidadeAtual;
        public int capacidadeTotal;
        public string[] alunos;

        public void getCapacidadeAtual(){
        capacidadeAtual = capacidadeTotal - alunos.Length;
        }
    }
}
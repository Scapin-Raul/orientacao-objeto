namespace SENAIzinho_Manha {
    public class Sala {
        public int NumeroSala { get; private set; }
        public int CapacidadeAtual { get; set; }
        public int CapacidadeTotal { get; }
        public Aluno[] Alunos { get; private set; }

        public Sala (int numeroSala, int capacidadeTotal) {
            this.CapacidadeTotal = capacidadeTotal;
            this.NumeroSala = numeroSala;
            this.CapacidadeAtual = capacidadeTotal;
            this.Alunos = new Aluno[capacidadeTotal];
        }

        public bool AlocarAluno (Aluno aluno, out string mensagem) {
            if (CapacidadeAtual >= 0) {
                for (int i = 0; i < Alunos.Length; i++) {
                    if (Alunos[i] == null) {
                        CapacidadeAtual--;
                        Alunos[i] = aluno;
                        mensagem = $"Aluno {aluno.Nome} alocado com sucesso!";
                        return true;
                    }
                }

            }
            mensagem = $"Não há mais vagas!";
            return false;
        }

        public string ExibirAlunos () {
            string nomesAlunos = "";
            foreach (var item in Alunos) {
                if (item != null) {
                    nomesAlunos += item.Nome + " ";
                }
            }
            return nomesAlunos;
        }
        public bool RemoverAluno (string nomeAlunosR, out string mensagem2) {
            for (int i = 0; i < this.Alunos.Length; i++) {
                if (CapacidadeAtual > 0) {
                    if (Alunos[i] != null && nomeAlunosR.Equals(Alunos[i].Nome)) {
                        Alunos[i] = null;
                        CapacidadeAtual++;
                        mensagem2 = $"Aluno {nomeAlunosR} removido com sucesso!";
                        return true;
                    }
                }
            }
            mensagem2 = $"{nomeAlunosR} não foi encontrado";
            return false;
        }

    }
}
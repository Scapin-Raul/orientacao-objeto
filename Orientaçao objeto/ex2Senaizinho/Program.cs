using System;

namespace ex2Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Senaizinho!!!!!");
            bool sair = false;
            Aluno[] alunos = new Aluno[10];
            int alunosCadastrados = 0;

            Sala[] salas = new Sala[3];
            int salasCadastradas =0;


            do{
                System.Console.WriteLine("------Menu------\n| 1 - Cadastrar Aluno\n| 2 - Cadastrar Sala\n| 3 - Alocar Aluno\n| 4 - Remover Aluno\n| 5 - Verificar Salas\n| 6 - Verificar Alunos\n| 0 - Sair");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1: //Cadastrar aluno
                        if (alunosCadastrados < alunos.Length){
                            Aluno a1 = new Aluno();
                            System.Console.Write("Insira o nome do aluno: ");
                            a1.nome = Console.ReadLine();
                            System.Console.Write("Insira a data de nascimento: ");
                            a1.dataNascimento = DateTime.Parse(Console.ReadLine());
                            System.Console.Write("Insira o curso:");
                            a1.curso = Console.ReadLine();

                            alunos[alunosCadastrados] = a1;
                            alunosCadastrados++;  
                            System.Console.WriteLine("Cadastro concluído!");
                        }else{
                            System.Console.WriteLine("\nO máximo de cadastros de alunos foi atingido.");
                        }

                    break;

                    case 2: // Cadastrar Sala
                        if (salasCadastradas < salas.Length){
                            Sala s1 = new Sala();
                            System.Console.Write("Insira o número da sala: ");
                            s1.numeroSala = int.Parse(Console.ReadLine());
                            System.Console.Write("Insira a capacidade da sala: ");
                            s1.capacidadeTotal = int.Parse(Console.ReadLine());
                            s1.capacidadeAtual = s1.capacidadeTotal;
                            s1.alunos = new string[s1.capacidadeTotal];
                            salas[salasCadastradas] =s1;
                            salasCadastradas++;
                        }else{
                            System.Console.WriteLine("\nO máximo de cadastros de salas foi atingido.");
                        }

                    break;

                    case 3: //Alocar aluno
                        if (alunosCadastrados < 1 || salasCadastradas < 1){
                            System.Console.WriteLine("\nVocê deve registrar ao menos 4 alunos e 1 sala para poder aloca-los.");
                        }else{
                            
                            int alunosAlocados = 0;
                            int salaAluno;
                            for (int i = 0; i < alunosCadastrados; i++){
                                if (alunos[i].numeroSala == 0){
                                    System.Console.WriteLine($"---Escolha uma das salas para o(a) {alunos[i].nome}---");
                                    for (int j = 0; j < salasCadastradas; j++){
                                        if (salas[j].capacidadeAtual > 0){
                                        System.Console.WriteLine($"| {j+1}ª Sala, número: {salas[j].numeroSala}");
                                        }//fim if
                                    }//fim for
                                    do{
                                        salaAluno = int.Parse(Console.ReadLine());
                                    } while (salaAluno != salas[0].numeroSala && salaAluno != salas[1].numeroSala && salaAluno != salas[2].numeroSala);
                                    alunos[i].numeroSala = salaAluno;

                                    for (int j = 0; j < salasCadastradas; j++)
                                    {
                                        if (alunos[i].numeroSala == salas[j].numeroSala){
                                            salas[j].capacidadeAtual--;
                                            alunosAlocados++;
                                            salas[j].setAlunos(alunos[i].nome);
                                        } //fim if   
                                    }//fim for
                                }//fim if inicial                            
                            }//fim for inicial
                            if (alunosAlocados == 0){
                                System.Console.WriteLine("\nNão há alunos para serem alocados.");
                            }
                        }
                    break;

                    case 4: //remover aluno
                        int remover;
                        System.Console.WriteLine("Qual aluno você gostaria de remover da sala?\n(Escreva o número do aluno)");
                        for (int i = 0; i < alunosCadastrados; i++){
                            // System.Console.WriteLine($"Aluno: {alunos[i].nome} | Sala: {alunos[i].numeroSala}");
                            if (alunos[i].numeroSala != 0){
                                    System.Console.WriteLine($"Aluno {i+1}: {alunos[i].nome} | Sala: {alunos[i].numeroSala}.");
                            }
                        }
                        // do{
                        remover = int.Parse(Console.ReadLine()) -1;
                        for (int i = 0; i < salasCadastradas; i++){
                            for (int j = 0; j < salas[i].cont; j++){

                                if (alunos[remover].nome == salas[i].alunos[j])
                                {
                                    salas[i].alunos[j]=null;
                                    salas[i].cont--;
                                    salas[i].capacidadeAtual++;
                                }
                            }
                        }

                        alunos[remover].numeroSala=0;                                                     
                    break;

                    case 5: //verificar salas
                        for (int i = 0; i < salasCadastradas; i++){
                            System.Console.WriteLine($"\n---{i+1}ª Sala---");
                            System.Console.WriteLine($"Numero da sala: {salas[i].numeroSala}");
                            System.Console.WriteLine($"Capacidade Atual: {salas[i].capacidadeAtual}");
                            if (salas[i].cont >0){
                                System.Console.Write("Alunos registrados nesta sala: ");

                                for (int j = 0; j < salas[i].cont; j++){
                                
                                    if (j == (salas[i].cont - 1)){
                                        System.Console.WriteLine($"{salas[i].alunos[j]}.");
                                    }else{
                                        System.Console.Write($"{salas[i].alunos[j]}, ");
                                    }
                                }
                            }else{
                                System.Console.WriteLine("Não há alunos registrados nesta sala.");
                            }
                        }
                        if (salasCadastradas == 0){
                            System.Console.WriteLine("Não há salas cadastradas.");
                        }
                            System.Console.WriteLine("\nPressione ENTER para continuar.");
                            Console.ReadLine();                                
                    break;

                    case 6: //verificar alunos
                        for (int i = 0; i < alunosCadastrados; i++)
                        {
                            System.Console.WriteLine($"\n---{i+1}º Aluno---");
                            System.Console.WriteLine($"Nome: {alunos[i].nome}.");
                            // System.Console.WriteLine($"Data de Nascimento: {alunos[i].dataNascimento:dd/MMM/yyyy}.");
                            System.Console.WriteLine($"Curso: {alunos[i].curso}.");
                            if (alunos[i].numeroSala != 0){
                                System.Console.WriteLine($"Nº da sala: {alunos[i].numeroSala}.");
                            }else{
                                System.Console.WriteLine("Sala ainda não registrada.");
                            }
                        }
                        System.Console.WriteLine("\nPressione ENTER para continuar.");
                        Console.ReadLine();
                        
                    break;
                    
                    case 0: //sair
                        sair =true;
                    break;
                }



                
            } while (!sair);


        }
    }
}

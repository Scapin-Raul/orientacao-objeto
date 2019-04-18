using System;

namespace ex2Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Bem vindo ao Senaizinho!!!!!");
            Console.ResetColor();            
            bool sair = false;
            Aluno[] alunos = new Aluno[10];
            int alunosCadastrados = 0;
            Sala[] salas = new Sala[3];
            int salasCadastradas =0;

            do{
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine("\n------Menu------\n| 1 - Cadastrar Aluno\n| 2 - Cadastrar Sala\n| 3 - Alocar Aluno\n| 4 - Remover Aluno\n| 5 - Verificar Salas\n| 6 - Verificar Alunos\n| 0 - Sair");                
                Console.ResetColor();            
                int escolha;
                string escolhaDigitada;
                do{
                    escolhaDigitada = Console.ReadLine();
                } while (!int.TryParse(escolhaDigitada, out escolha));
                
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
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("Cadastro de aluno concluído!");
                            Console.ResetColor();            

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

                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("Cadastro de sala concluído!");
                            Console.ResetColor();            

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
                                    System.Console.WriteLine($"---Escolha uma das salas para o(a) {alunos[i].nome}---\n(Digite 0 para não registrar sala)");
                                    for (int j = 0; j < salasCadastradas; j++){
                                        if (salas[j].capacidadeAtual > 0){
                                        System.Console.WriteLine($"| {j+1}ª Sala, número: {salas[j].numeroSala}");
                                        }//fim if
                                    }//fim for
                                    do{
                                        salaAluno = int.Parse(Console.ReadLine());
                                        if (salaAluno == 0){
                                            break;
                                        }
                                    } while (salaAluno != salas[0].numeroSala && salaAluno != salas[1].numeroSala && salaAluno != salas[2].numeroSala);
                                    alunos[i].numeroSala = salaAluno;

                                    for (int j = 0; j < salasCadastradas; j++)
                                    {
                                        if (alunos[i].numeroSala == salas[j].numeroSala){
                                            alunosAlocados++;
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            System.Console.WriteLine(salas[j].setAlunos(alunos[i].nome));
                                            Console.ResetColor();            
                                        } //fim if   
                                    }//fim for
                                }//fim if inicial                            
                            }//fim for inicial
                            if (alunosAlocados == 0){
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                System.Console.WriteLine("\nNão há ou não foram alocados nenhum aluno.");
                                Console.ResetColor();            
                            }//fim if
                        }//fim else
                    break;

                    case 4: //remover aluno
                        int remover;
                        System.Console.WriteLine("Qual aluno você gostaria de remover da sala?\n(Escreva o número do aluno ou 0 para voltar ao menu.)");
                        for (int i = 0; i < alunosCadastrados; i++){
                            if (alunos[i].numeroSala != 0){
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                System.Console.Write($"Aluno {i+1}:");
                                Console.ResetColor();            
                                System.Console.WriteLine($" {alunos[i].nome} | Sala: {alunos[i].numeroSala}.");
                            }
                        }
                        remover = int.Parse(Console.ReadLine()) -1;
                        
                        if (remover < 0){
                            break;
                        }

                        for (int i = 0; i < salasCadastradas; i++){
                            for (int j = 0; j < salas[i].cont; j++){
                                if (alunos[remover].nome == salas[i].alunos[j]){
                                    salas[i].alunos[j]=null;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    System.Console.WriteLine(salas[i].removerAlunos());
                                    Console.ResetColor();     
                                    break;       
                                }
                            }//fim for j
                        }//fim for i

                        alunos[remover].numeroSala=0;                                                     
                    break;

                    case 5: //verificar salas
                        for (int i = 0; i < salasCadastradas; i++){
                            System.Console.WriteLine($"\n---{i+1}ª Sala---");
                            System.Console.WriteLine($"Numero da sala: {salas[i].numeroSala}");
                            System.Console.WriteLine($"Capacidade Atual: {salas[i].capacidadeAtual}");
                            if (salas[i].cont >0){
                            System.Console.Write("Alunos registrados nesta sala: ");
                            System.Console.WriteLine(salas[i].exibirAlunos());
                            }else{
                                System.Console.WriteLine("Não há alunos registrados nesta sala.");
                            }
                        }//fim for
                        if (salasCadastradas == 0){

                            System.Console.WriteLine("Não há salas cadastradas.");
                        }
                        System.Console.WriteLine("\nPressione ENTER para continuar.");
                        Console.ReadLine();                                
                    break;

                    case 6: //verificar alunos
                        if (alunosCadastrados >0){
                            for (int i = 0; i < alunosCadastrados; i++)
                            {
                                System.Console.WriteLine($"\n---{i+1}º Aluno---");
                                System.Console.WriteLine($"Nome: {alunos[i].nome}.");
                                System.Console.WriteLine($"Curso: {alunos[i].curso}.");
                                if (alunos[i].numeroSala != 0){
                                    System.Console.WriteLine($"Nº da sala: {alunos[i].numeroSala}.");
                                }else{
                                    System.Console.WriteLine("Sala ainda não registrada.");
                                }
                            }
                        }else{
                            System.Console.WriteLine("Não há alunos cadastrados.");
                        }

                        System.Console.WriteLine("\nPressione ENTER para continuar.");
                        Console.ReadLine();                        
                    break;
                    
                    case 0: //sair
                        sair =true;
                    break;
                }//fim do switch
            } while (!sair);
        }
    }
}

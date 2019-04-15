using System;

namespace ex2Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Senaizinho!!!!!");
            bool sair = false;
            Aluno[] alunos = new Aluno[5];
            int alunosCadastrados = 0;

            Sala[] salas = new Sala[3];
            int salasCadastradas =0;


            do{
                System.Console.WriteLine("------Menu------\n| 1 - Cadastrar Aluno\n| 2 - Cadastrar Sala\n| 3 - Alocar Aluno\n| 4 - Remover Ultimo Aluno Registrado\n| 5 - Verificar Salas\n| 6 - Verificar Alunos\n| 0 - Sair");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1: //Cadastrar aluno
                        Aluno a1 = new Aluno();
                        System.Console.Write("Insira o nome do aluno: ");
                        a1.nome = Console.ReadLine();
                        System.Console.Write("Insira a data de nascimento: ");
                        a1.dataNascimento = DateTime.Parse(Console.ReadLine());
                        System.Console.Write("Insira o curso:");
                        a1.curso = Console.ReadLine();
                        // System.Console.Write("Insira o Nº da sala:");
                        // a1.numeroSala = int.Parse(Console.ReadLine());

                        alunos[alunosCadastrados] = a1;
                        alunosCadastrados++;

                    break;

                    case 2: // Cadastrar Sala
                        Sala s1 = new Sala();
                        System.Console.Write("Insira o número da sala: ");
                        s1.numeroSala = int.Parse(Console.ReadLine());
                        System.Console.Write("Insira a capacidade da sala: ");
                        s1.capacidadeTotal = int.Parse(Console.ReadLine());

                        salas[salasCadastradas] =s1;
                        salasCadastradas++;
                    break;

                    case 3: //Alocar aluno

                    break;

                    case 4: //remover aluno
                        alunosCadastrados--;
                    break;

                    case 5: //verificar salas
                        for (int i = 0; i < salasCadastradas; i++){
                            System.Console.WriteLine($"\n---{i+1}ª Sala---");
                            System.Console.WriteLine($"Numero da sala: {salas[i].numeroSala}");
                            System.Console.WriteLine($"Capacidade Total: {salas[i].capacidadeTotal}");
                            salas[i].getCapacidadeAtual();
                            System.Console.WriteLine($"Capacidade Atual: {salas[i].capacidadeAtual}");
                        }
                    break;

                    case 6: //verificar alunos
                        for (int i = 0; i < alunosCadastrados; i++)
                        {
                            System.Console.WriteLine($"\n---{i+1}º Aluno---");
                            System.Console.WriteLine($"Nome: {alunos[i].nome}.");
                            System.Console.WriteLine($"Data de Nascimento: {alunos[i].dataNascimento:dd/MMM/yyyy}.");
                            System.Console.WriteLine($"Curso: {alunos[i].curso}.");
                            System.Console.WriteLine($"Nº da sala: {alunos[i].numeroSala}.");
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

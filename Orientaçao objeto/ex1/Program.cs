using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bem vindo ao banco Lacraste!");

            ContaCorrente conta1 = new ContaCorrente();

            System.Console.Write("Insira o nome: ");
            conta1.titular = Console.ReadLine();
            System.Console.Write("Insira a agencia: ");
            conta1.agencia= int.Parse(Console.ReadLine());
            System.Console.Write("Insira o numero da conta: ");
            conta1.numeroConta= int.Parse(Console.ReadLine());
            // System.Console.Write("Insira a quantidade do deposito: ");
            // conta1.Depositar(double.Parse(Console.ReadLine())); 
            conta1.Depositar(2000); 
            // System.Console.Write("Insira a quantidade do saque: ");
            // conta1.Sacar(double.Parse(Console.ReadLine())); 
            

            ContaCorrente conta2 = new ContaCorrente();

            System.Console.Write("\nInsira o nome: ");
            conta2.titular = Console.ReadLine();
            System.Console.Write("Insira a agencia: ");
            conta2.agencia= int.Parse(Console.ReadLine());
            System.Console.Write("Insira o numero da conta: ");
            conta2.numeroConta= int.Parse(Console.ReadLine());
            // System.Console.Write("Insira a quantidade do deposito: ");
            // conta2.Depositar(double.Parse(Console.ReadLine())); 
            conta2.Depositar(3000); 
            // System.Console.Write("Insira a quantidade do saque: ");
            // conta2.Sacar(double.Parse(Console.ReadLine())); 



            System.Console.WriteLine("------------Conta 1-----------");
            System.Console.WriteLine($"Titular: {conta1.titular}");
            System.Console.WriteLine($"Agencia: {conta1.agencia}");
            System.Console.WriteLine($"Nº da conta: {conta1.numeroConta}");
            System.Console.WriteLine($"Saldo: {conta1.saldoConta}");

            System.Console.WriteLine("------------Conta 2-----------");
            System.Console.WriteLine($"Titular: {conta2.titular}");
            System.Console.WriteLine($"Agencia: {conta2.agencia}");
            System.Console.WriteLine($"Nº da conta: {conta2.numeroConta}");
            System.Console.WriteLine($"Saldo: {conta2.saldoConta}");
            
            bool resultadoTransferencia;
            do
            {
            System.Console.Write("---------------------------------\nInsira o valor da transferencia da conta 1 para a conta2: ");
            resultadoTransferencia = conta1.Transferir(double.Parse(Console.ReadLine()),conta2);
                
            } while (!resultadoTransferencia);

            System.Console.WriteLine($"-----------------------------\nSaldo conta 1: {conta1.saldoConta}");
            System.Console.WriteLine($"Saldo conta 2: {conta2.saldoConta}");

        }
    }
}

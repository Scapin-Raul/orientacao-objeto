using System;
namespace Pizzuka
{
   public class Usuario2
   {
       static Usuario2[] arrayDeUsuarios = new Usuario2[5];
       public static int contador = 0;
       public int Id {get; set;}

       public string Nome {get; set;}

       public string Email {get; set;}

       public string Senha {get; set;}

       public DateTime Data {get; set;}

       public static void Inserir(){
           string nome;
           string email;
           string senha;

           Console.WriteLine("Digite o nome do usuário");
           nome = Console.ReadLine();
           do
           {
           Console.WriteLine("Digite o e-mail do usuário");
           email = Console.ReadLine();
           if(!email.Contains("@") || !email.Contains(".")){
               Console.WriteLine("E-mail inválido");
           }
           } while (!email.Contains("@") || !email.Contains("."));
           do
           {
               Console.WriteLine("Digite a senha do usuário");
               senha = Console.ReadLine();
               if(senha.Length < 6){
                   Console.WriteLine("Senha inválida, deve conter no mínimo 6 caracteres");
               }else{
                   Console.WriteLine("Usuário cadastrao com sucesso");
               }
           } while (senha.Length < 6);

           arrayDeUsuarios[contador] = new Usuario2();
           arrayDeUsuarios[contador].Id = contador + 1;
           arrayDeUsuarios[contador].Nome = nome;
           arrayDeUsuarios[contador].Email = email;
           arrayDeUsuarios[contador].Senha = senha;
           arrayDeUsuarios[contador].Data = DateTime.Now;
           contador++;

       }

       public static void EfetuarLogin(){
           string email;
           string senha;

           Console.WriteLine("Digite o e-mail do usuário");
           email = Console.ReadLine();
           Console.WriteLine("Digite a senha");
           senha = Console.ReadLine();
           foreach (var item in arrayDeUsuarios)
           {
               if (item != null)
               {
                       if (email.Equals(item.Email) && senha.Equals(item.Senha) )
               {
                   Console.WriteLine($"Seja bem vindo - {item.Nome}");
               }else{
                   Console.WriteLine("Email ou Senha incorretos");
               }
               }

           }
       }
       public static void Listar(){
           foreach (var item in arrayDeUsuarios)
           {
               if (item == null)
               {
                   break;
               }
               Console.WriteLine($"Id: {item.Id} Usuário: {item.Nome}");

           }
       }


   }
}
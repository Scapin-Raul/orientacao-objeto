namespace TodoList.Utils
{
    public class MenuUtils
    {
        public static void MenuUser(){
            System.Console.WriteLine("\n---Menu---");
            System.Console.WriteLine("1- Criar conta");
            System.Console.WriteLine("2- Logar");
            System.Console.WriteLine("3- Listar usuários");
            System.Console.WriteLine("0- Sair");
        }    

        public static void MenuLogado(){
            System.Console.WriteLine("\n---Gerenciado de Tarefas---");
            System.Console.WriteLine("1- Criar Tarefa");
            System.Console.WriteLine("2- Listar Tarefas");
            System.Console.WriteLine("9- Sair");
        }
    }
}
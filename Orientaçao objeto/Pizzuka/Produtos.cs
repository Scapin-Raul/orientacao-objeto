namespace Pizzuka
{
    using System;
    public class Produtos
    {
        static Produtos[] arrayDeProdutos = new Produtos[10];
        public int Id;
        public string Nome;
        public string Descricao;
        public float Preco;
        public string Categoria;
        public DateTime Data;
        public static int cont = 0;

        public static void Cadastrar(){
            int id;
            string nome;
            string descricao;
            float preco;
            string categoria;

            System.Console.Write("Digite o nome do produto: ");
            nome = Console.ReadLine();
            System.Console.Write("Digite a descrição do produto: ");
            descricao = Console.ReadLine();
            System.Console.Write("Digite o preço do produto: ");
            preco = float.Parse(Console.ReadLine());
            System.Console.Write("Digite a categoria do produto: ");
            categoria = Console.ReadLine();
            
            arrayDeProdutos[cont] = new Produtos();
            arrayDeProdutos[cont].Nome = nome;
            arrayDeProdutos[cont].Descricao = descricao;
            arrayDeProdutos[cont].Preco = preco;
            arrayDeProdutos[cont].Categoria = categoria;
            arrayDeProdutos[cont].Data = DateTime.Now;
            arrayDeProdutos[cont].Id = cont+1;
            cont++;
            
        }
        public static void Listar(){
            foreach (var item in arrayDeProdutos){
                if (item != null){
                    System.Console.WriteLine($"\n------\nId: {item.Id}.\nNome: {item.Nome}.\nPreço: R${item.Preco}.");
                }
            }
        }

        public static void Buscar(){
            System.Console.Write("Digite o ID do produto que deseja consultar: ");
            int busca = int.Parse(Console.ReadLine());
            bool exibiu = false;
            foreach (var item in arrayDeProdutos){
                if (item != null && item.Id == busca){
                    System.Console.WriteLine($"\n---Produto ID {item.Id}---\nNome: {item.Nome}\nDescrição: {item.Descricao}.\nCategoria: {item.Categoria}.\nPreço: R${item.Preco}.\nData de Criação: {item.Data}.");
                    exibiu = true;
                    break;
                }
            }
            if (exibiu == false){
            System.Console.WriteLine("Nenhum produto com este ID foi encontrado.");
            }
        }
        
    }
}
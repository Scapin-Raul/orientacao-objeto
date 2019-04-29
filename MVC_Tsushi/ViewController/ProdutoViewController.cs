using System;
using System.Collections.Generic;
using MVC_Tsushi.Repositorio;
using MVC_Tsushi.ViewModel;

namespace MVC_Tsushi.ViewController
{
    public class ProdutoViewController
    {   
        
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio(); 
#region CADASTRAR_PRODUTO
public static void CadastrarProduto(){
string nome, descricao, categoria;
float preco;

do{
    System.Console.WriteLine("Insira o nome do produto:");
    nome = Console.ReadLine();
    if (string.IsNullOrEmpty(nome)){
        System.Console.WriteLine("Nome de produto inválido");
    }
} while (string.IsNullOrEmpty(nome));

do{
    System.Console.WriteLine("Insira a descrição do produto:");
    descricao = Console.ReadLine();
    if (string.IsNullOrEmpty(descricao)){
        System.Console.WriteLine("Descrição de produto inválido");
    }
} while (string.IsNullOrEmpty(descricao));

do{
    System.Console.WriteLine("Insira a categoria do produto:");
    categoria = Console.ReadLine();
    if (string.IsNullOrEmpty(categoria)){
        System.Console.WriteLine("Categoria de produto inválido");
    }
} while (string.IsNullOrEmpty(categoria));

do{
    System.Console.WriteLine("Insira o preço do produto:");
    preco = float.Parse(Console.ReadLine());
    if (float.IsNegative(preco)){
        System.Console.WriteLine("Preço de produto inválido");
    }
} while (float.IsNegative(preco));

ProdutoViewModel produtoViewModel = new ProdutoViewModel();
produtoViewModel.Nome = nome;
produtoViewModel.Categoria = categoria;
produtoViewModel.Descricao = descricao;
produtoViewModel.Preco = preco;

produtoRepositorio.Inserir(produtoViewModel);

System.Console.WriteLine("Produto cadastrado com sucesso!");
}
#endregion
#region LISTAR_PRODUTOS
        public static void ListarProduto(){
            List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.Listar();
            foreach (var item in listaDeProdutos){
                System.Console.WriteLine($"ID: {item.Id} - Nome: {item.Nome} - Preço: {item.Preco}");
            }
        }
        #endregion
#region BUSCAR_ID    
        public static void BuscarId(){
            System.Console.WriteLine("Insira o ID do produto que gostaria de consultar:");
            int idBusca = int.Parse(Console.ReadLine());
            
            ProdutoViewModel produtoRecuperado = ProdutoRepositorio.BuscarId(idBusca);

            if (produtoRecuperado != null){
                System.Console.WriteLine($"ID: {produtoRecuperado.Id} - Nome: {produtoRecuperado.Nome} - Categoria: {produtoRecuperado.Categoria} - Descrição: {produtoRecuperado.Descricao} - Preço: {produtoRecuperado.Preco} - Data Criaçao: {produtoRecuperado.DataCriacao}");
            }else{
                System.Console.WriteLine("Não há nenhum produto cadastrado com este ID");
            }
        }
#endregion

    }
}
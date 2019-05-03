using System;
using System.Collections.Generic;
using System.IO;
using MVC_Tsushi.ViewModel;

namespace MVC_Tsushi.Repositorio
{
    public class ProdutoRepositorio
    {
        // static List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();
#region INSERIR_PRODUTO
        /// <summary>METODO RESPONSAVEL POR ARMAZENAR UM PRODUTO</summary> 
        public ProdutoViewModel Inserir(ProdutoViewModel produto){
            int contador = 0;
            List<ProdutoViewModel> listaDeProdutos = Listar();
            // if (listaDeProdutos != null){
                contador = listaDeProdutos.Count;
            // }
            
            
            produto.Id = contador +1;
            produto.DataCriacao = DateTime.Now;
            
            StreamWriter sw = new StreamWriter("produtos.csv",true);
            sw.WriteLine($"{produto.Id};{produto.Nome};{produto.Categoria};{produto.Descricao};{produto.Preco};{produto.DataCriacao};");
            sw.Close();
        
            return produto;
        }
#endregion
#region LISTAR_PRODUTOS
        /// <summary>RETORNA LISTA DE PRODUTOS</summary>
        public List<ProdutoViewModel> Listar(){
            List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();
            ProdutoViewModel produtoViewModel;
            if (!File.Exists("produtos.csv")){
                return null;
            }

            string[] produtos = File.ReadAllLines("produtos.csv");
            
            foreach (var item in produtos){
                if (item != null){
                            
                    string[] dadosDeCadaProduto = item.Split(";");     
                    produtoViewModel = new ProdutoViewModel();
                    produtoViewModel.Id = int.Parse(dadosDeCadaProduto[0]);
                    produtoViewModel.Nome =dadosDeCadaProduto[1];
                    produtoViewModel.Categoria =dadosDeCadaProduto[2];
                    produtoViewModel.Descricao =dadosDeCadaProduto[3];
                    produtoViewModel.Preco = float.Parse(dadosDeCadaProduto[4]);
                    produtoViewModel.DataCriacao = DateTime.Parse(dadosDeCadaProduto[5]);

                    listaDeProdutos.Add(produtoViewModel);
                }
            }
                
            return listaDeProdutos;
        }
#endregion
#region BUSCAR_ID
        /// <summary>VERIFICA SE O ID É VALIDO</summary>
        /// <param name="id">Id do produto</param>
        /// <returns>Retorna o produto caso ele seja encontrado ou null caso não</returns>
        public ProdutoViewModel BuscarId(int id){
            List<ProdutoViewModel> listaDeProdutos = Listar();
            foreach (var item in listaDeProdutos){
                if (item.Id == id){
                    return item;
                }
            }
            return null;
        }
#endregion
    }
}
using System;
using System.Collections.Generic;
using MVC_Tsushi.ViewModel;

namespace MVC_Tsushi.Repositorio
{
    public class ProdutoRepositorio
    {
        static List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();
#region INSERIR_PRODUTO
        /// <summary>METODO RESPONSAVEL POR ARMAZENAR UM PRODUTO</summary> 
        public ProdutoViewModel Inserir(ProdutoViewModel produto){
            produto.Id = listaDeProdutos.Count + 1;
            produto.DataCriacao = DateTime.Now;
        
            //insere o obj produto na lista
            listaDeProdutos.Add(produto);
            return produto;
        }
#endregion
#region LISTAR_PRODUTOS
        /// <summary>RETORNA LISTA DE USUARIOS</summary>
        public List<ProdutoViewModel> Listar(){
            return listaDeProdutos;
        }
#endregion
#region BUSCAR_ID
        /// <summary>VERIFICA SE O ID É VALIDO</summary>
        /// <param name="id">Id do produto</param>
        /// <returns>Retorna o produto caso ele seja encontrado ou null caso não</returns>
        public static ProdutoViewModel BuscarId(int id){
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
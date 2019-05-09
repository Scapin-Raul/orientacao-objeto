using System.Collections.Generic;

namespace Reciclagem.Model
{
    public class TodosLixos
    {
        public static Dictionary<int,Lixo> TiposLixos = new Dictionary<int, Lixo>(){
            { 1, new Sacola() },
            { 2, new CaixaDePapelao() },
            { 3, new GarrafaPet() },
            { 4, new GarrafaVidro() },
            { 5, new CascaDeBanana() },
            { 6, new FolhaDePapel() },
            { 7, new EmbalagemMetalica() },
            { 8, new Teclado() }
        };
    }
}
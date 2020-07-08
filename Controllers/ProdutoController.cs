using System.Collections.Generic;
using Aula43MVC.Models;
using Aula43MVC.Views;

namespace Aula43MVC.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();

        ProdutoViews produtoViews = new ProdutoViews();

        public void Listar(){
            produtoViews.MostrarNoConsole( produtoModel.Ler() );
        }

        public void Filtrar(string _preco){
            List<Produto> lista = produtoModel.Ler();
            lista = lista.FindAll(x => x.Preco == float.Parse(_preco));
            produtoViews.MostrarNoConsole( lista );
        }
    }
}
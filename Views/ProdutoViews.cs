using System.Collections.Generic;
using Aula43MVC.Models;

namespace Aula43MVC.Views
{
    public class ProdutoViews
    {
        public void MostrarNoConsole(List<Produto> lista){
            foreach(Produto item in lista){
                System.Console.WriteLine($"{item.Preco} - {item.Nome} ");
            }
        }
    }
}
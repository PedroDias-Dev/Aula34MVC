using System;
using Aula43MVC.Controllers;

namespace Aula43MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();

            //produto.Listar();
            produto.Filtrar("7500");
        }
    }
}

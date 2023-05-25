using MVC_Console.Models;
using MVC_Console.View;

namespace MVC_Console.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }

        public void Cadastrar()
        {
            Produto novoProduto = produtoView.Cadastrar();

            produto.Inserir(novoProduto);
        }
    }
}
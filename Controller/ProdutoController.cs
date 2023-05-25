using MVC_Console.Models;
using MVC_Console.View;

namespace MVC_Console.Controller
{
    public class ProdutoController
    {
        //instância de objeto produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //método controlador para acessar a listagem de produtos
        public void Listar()
        {
            //lista de produtos que recebe os itens obtidos pelo método Ler da model
            List<Produto> produtos = produto.Ler();

            //chamada para o método Listar da View, passando como parâmetro a lista obtida acima
            produtoView.Listar(produtos);
        }

        //método controlador para acessar a funcionalidade de cadastro de produtos
        public void Cadastrar()
        {
            //objeto que vai armazenar o produto criado
            Produto novoProduto = produtoView.Cadastrar();

            //chamada para o método de inserir da View, passando como parâmetro o objeto cadastrado
            produto.Inserir(novoProduto);
        }
    }
}
using MVC_Console.Models;

namespace MVC_Console.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto)
        {
            Console.Clear();

            foreach (var item in produto)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}");
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o código: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome: ");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preço: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;
        }
    }
}
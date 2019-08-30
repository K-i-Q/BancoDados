using BancoDados.DAL;
using BancoDados.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.View
{
    class CadastrarProduto
    {
        public static void Renderizar()
        {

            Produto produto = new Produto();
            Console.WriteLine("Cadastrar Produto");
            Console.WriteLine("Digite o nome");
            produto.Nome = Console.ReadLine().ToLower();
            Console.WriteLine("Digite o preço");
            produto.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade");
            produto.Quantidade = Convert.ToInt32(Console.ReadLine());
            ProdutoDAO.AdicionarProduto(produto);


        }
    }
}

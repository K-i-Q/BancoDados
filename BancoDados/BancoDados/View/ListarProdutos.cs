using BancoDados.DAL;
using BancoDados.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.View
{
    class ListarProdutos
    {
        public static void Renderizar()
        {
            Console.WriteLine("Listar produtos");
            foreach (Produto p in ProdutoDAO.ListarProdutos())
            {
                Console.WriteLine(p.Nome);
            }
        }
    }
}

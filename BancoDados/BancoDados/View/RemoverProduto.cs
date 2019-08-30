using BancoDados.DAL;
using BancoDados.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.View
{
    class RemoverProduto
    {
        public static void Renderizar()
        {
            
            Console.WriteLine("Remover Produto");
            Console.WriteLine("Digite o nome");
            ProdutoDAO.RemoverProduto(Console.ReadLine().ToLower());
        }
    }
}

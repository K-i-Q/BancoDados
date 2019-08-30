using BancoDados.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.DAL
{
    class ProdutoDAO
    {
        private static Context ctx = new Context();

        public static void AdicionarProduto(Produto produto)
        {
            ctx.Produtos.Add(produto);
            ctx.SaveChanges();
        }
        public static void RemoverProduto(string produto)
        {
            ctx.Produtos.Remove(BuscarProduto(produto));
            ctx.SaveChanges();
        }
        public static Produto BuscarProduto(string nome)
        {
            foreach (Produto p in ListarProdutos())
            {
                if (nome == p.Nome)
                {
                    return p;
                }
            }
            return null;
        }
        public static List<Produto> ListarProdutos() => ctx.Produtos.ToList();
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Model
{
    class Context : DbContext
    {
        //Nomear o arquivo do banco de dados
        public Context() : base("DbProdutos")
        {

        }
        public DbSet<Produto> Produtos { get; set; }
    }
}

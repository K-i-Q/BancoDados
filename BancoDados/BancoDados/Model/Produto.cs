using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Model
{
    [Table("Produtos")]
    class Produto
    {
        public Produto()
        {
            CriadoEm = DateTime.Now;
        }

        //Name "Id" in property
        //Nome da classe antes de "Id" Ex: "ProdutoId"
        //[Key]
        [Key]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }
        public string Categoria { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("| ");
            sb.Append("Nome: ");
            sb.Append(Nome);
            sb.Append(" | ");
            sb.Append("Estoque: ");
            sb.Append(Quantidade);
            sb.Append(" | ");
            sb.Append("Preço: ");
            sb.Append(Preco);
            sb.Append(" | ");

            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            Produto p = (Produto)obj;
            return Nome == p.Nome;
        }
    }
}

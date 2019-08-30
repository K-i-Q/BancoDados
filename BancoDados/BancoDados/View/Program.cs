using BancoDados.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;

            

            do
            {
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Remover Produto");
                Console.WriteLine("4 - Editar Produto");
                Console.WriteLine("0 - Sair");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        //cadastrar
                        CadastrarProduto.Renderizar();
                        break;
                    case 2:
                        //listar
                        ListarProdutos.Renderizar();
                        break;
                    case 3:
                        //remover
                        RemoverProduto.Renderizar();
                        break;
                    case 4:
                        //editar
                        break;
                    case 0:
                        //saindo
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (menu != 0);
        }
    }
}

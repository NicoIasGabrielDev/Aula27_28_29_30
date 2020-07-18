using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 9;
            p1.Nome = "Lewandowski";
            p1.Preco = 9000f;

            p1.Cadastrar(p1);

            Produto alterado = new Produto();
            alterado.Codigo = 11;
            alterado.Nome = "Neymar";
            alterado.Preco = 11000f;

            p1.Alterar(alterado);

            p1.Remover("Lewandowski");

            List<Produto> lista = p1.Ler();

            foreach (Produto item in lista)
            {
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }

        }
    }
}

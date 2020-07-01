using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
           Produto p = new Produto();
           p.Codigo = 10;
           p.Nome = "Messi";
           p.Preco =10000f;

           p.Inserir(p);

           List<Produto> lista = new List<Produto>();
           lista = p.Ler();

           foreach (Produto item in lista)
           {
               Console.WriteLine($"R${item.Preco} - {item.Nome}");
           }
           lista.Find( p => p.Nome == "Messi" );
        }
    }
}

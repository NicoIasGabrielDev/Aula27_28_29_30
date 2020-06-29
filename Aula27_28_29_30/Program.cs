using System;

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
        }
    }
}

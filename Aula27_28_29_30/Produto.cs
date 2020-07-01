using System;
using System.Collections.Generic;
using System.IO;

namespace Aula27_28_29_30

{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/Produto.csv";
        public Produto()
        {
            //Criando arquivo se não existir
            if( !File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        public void Inserir(Produto p)
        {
            var linha = new string[] {p.PrepararLinhaCSV(p) };
            File.AppendAllLines(PATH,linha);
        }
        private string PrepararLinhaCSV(Produto p)
        {
            return $"codigo={p.Codigo};nome={p.Nome};preco={p.Preco};";
        }
        public List<Produto> Ler()
        {
            //criamos uma lista de produtos
            List<Produto> produtos = new List<Produto>();
            

            //Transformaos as linhas em um array de strings
            string[] linhas = File.ReadAllLines(PATH);
            

            //Varremos este array de strings
            foreach(var linha in linhas)
            {
                //quebramos cada linha em partes, pegando
                string[] dados = linha.Split(";");
    

                //Tratamos os dados e adicionamos em um novo produto
                Produto prod = new Produto();
                prod.Codigo  = Int32.Parse( Separar(dados[0]) );
                prod.Nome    = Separar(dados[1]);
                prod.Preco   = float.Parse( Separar(dados[2]) );

                //adicionamos o item na lista antes de retorná-la
                produtos.Add(prod);
            }

            return produtos;    
        }
        public string Separar(string dado)
        {
            
            return dado.Split("=")[1];
        }
    }
}
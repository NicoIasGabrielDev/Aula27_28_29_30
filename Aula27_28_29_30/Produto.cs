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
    }
}

using Module;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Insira o preco: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Insira a quantidade: ");
            double quantidade = double.Parse(Console.ReadLine());

            Module.Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine($"Nome do produto: { produto.Nome }");

            Console.Write("Insira o nome: ");
            produto.Nome = Console.ReadLine();
            Console.WriteLine($"Nome do produto: {produto.Nome}");
        }
    }
}
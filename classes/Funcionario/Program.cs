namespace Sistema
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Insira o salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Insira o imposto: ");
            double imposto = double.Parse(Console.ReadLine());

            Funcionario func = new Funcionario(nome, salario, imposto);

            Console.Write("Funcionário: " + func);

            Console.WriteLine();
            Console.Write("Digite a percentagem para aumentar salário: ");
            double aumento = double.Parse(Console.ReadLine());

            func.AumentarSalario(aumento);

            Console.Write("Funcionário: " + func);

        }
    }
}
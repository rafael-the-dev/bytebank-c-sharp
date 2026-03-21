using System;
using System.Globalization;

namespace Sistema
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public Funcionario(string nome, double salario, double imposto)
        {
            Nome = nome;
            Salario = salario;
            Imposto = imposto;
        }

        public double CalculaSalarioLiquido()
        {
            return Salario - Imposto;
        }
        public void AumentarSalario(double percentagem)
        {
            double aumento = (percentagem * Salario) / 100;

            Salario += aumento;
        }

        public override string ToString()
        {
            return Nome + " , $ " + CalculaSalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.10);
            // Salario = Salario * 1.10;
            Salario *= 1.1;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}

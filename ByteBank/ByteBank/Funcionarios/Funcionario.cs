using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        public Funcionario(string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;

            TotalDeFuncionarios++;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}

using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "12345");

            carlos.Nome = "Carlos";

            gerenciador.Registrar(carlos);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.Salario);
            Console.WriteLine(carlos.GetBonificacao());

            Diretor roberta = new Diretor("54321");

            roberta.Nome = "Roberta";

            gerenciador.Registrar(roberta);

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.Salario);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + gerenciador.getTotalBonificacao());

            // Código válido.
            /*
            Funcionario pedro = new Diretor();

            Funcionario robertaTeste = new Funcionario();
            robertaTeste = roberta;

            Console.WriteLine("Bonificação de referência de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de referência de Funcionário: " + robertaTeste.GetBonificacao());
            */

            Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

            carlos.AumentarSalario();
            roberta.AumentarSalario();

            Console.WriteLine("Novo salário de " + carlos.Nome + " é " + carlos.Salario);
            Console.WriteLine("Novo salário de " + roberta.Nome + " é " + roberta.Salario);

            Console.ReadLine();
        }
    }
}

using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("12345");

            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Diretor roberta = new Diretor("54321");

            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Console.WriteLine(roberta.Nome);
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

            Console.ReadLine();
        }
    }
}

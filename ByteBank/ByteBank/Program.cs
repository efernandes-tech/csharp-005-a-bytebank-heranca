using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "12345";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Diretor roberta = new Diretor();

            roberta.Nome = "Roberta";
            roberta.CPF = "54321";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + gerenciador.getTotalBonificacao());

            // Código válido.
            Funcionario pedro = new Diretor();

            Funcionario robertaTeste = new Funcionario();
            robertaTeste = roberta;

            Console.WriteLine("Bonificação de referência de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de referência de Funcionário: " + robertaTeste.GetBonificacao());

            Console.ReadLine();
        }
    }
}

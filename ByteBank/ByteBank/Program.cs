using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
           
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("123");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("456");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("789");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("159");
            camila.Nome = "Camila";

            Funcionario camilaTeste = new GerenteDeConta("159");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificações do Mês: "
                + gerenciadorBonificacao.getTotalBonificacao());
        }
    }
}

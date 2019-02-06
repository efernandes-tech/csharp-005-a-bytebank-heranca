using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();

            UsarSistema();
           
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("456");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "abc");

            GerenteDeConta camila = new GerenteDeConta("159");
            camila.Nome = "Camila";
            camila.Senha = "456";

            sistemaInterno.Logar(camila, "456");
            sistemaInterno.Logar(camila, "abc");
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

            Desenvolvedor guilherme = new Desenvolvedor("753");
            guilherme.Nome = "Gilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de Bonificações do Mês: "
                + gerenciadorBonificacao.getTotalBonificacao());
        }
    }
}

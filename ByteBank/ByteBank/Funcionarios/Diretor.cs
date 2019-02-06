using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Diretor : Funcionario
    {
        public double GetBonificacao()
        {
            return Salario;
        }
    }
}

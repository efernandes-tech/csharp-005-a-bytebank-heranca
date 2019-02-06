using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario;
        }
    }
}

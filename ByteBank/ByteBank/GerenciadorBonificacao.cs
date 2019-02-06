using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double getTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}

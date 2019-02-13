using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum_CaixaEletronico.Contas;

namespace Caelum_CaixaEletronico
{
    class TotalizadorDeContas
    {
        public double SaldoTotal { get; private set; }

        public void Acumula(Conta conta)
        {
            this.SaldoTotal += conta.Saldo;
        }

    }
}

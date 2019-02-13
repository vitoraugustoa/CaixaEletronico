using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum_CaixaEletronico.Contas;

namespace Caelum_CaixaEletronico
{
    class SeguroDeVida : Conta , Tributavel
    {
        public override void Saca(Double ValorASerSacado)
        {
            this.Saldo += ValorASerSacado;
        }

        public double CalculaTributo()
        {
            return this.Saldo - 42;
        }

    }
}

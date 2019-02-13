using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum_CaixaEletronico.Contas;

namespace Caelum_CaixaEletronico
{
    class ContaInvestimento : Conta , Tributavel
    {
        public override void Saca(double valorAserSacado)
        {
            if( valorAserSacado <= 0)
            {
                throw new ArgumentException();
            }

            if (this.Saldo >= valorAserSacado)
            {
                this.Saldo -= valorAserSacado;

            }else
            {
                throw new SaldoInsuficienteException();
            }
        }

        public  double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }

    }
}

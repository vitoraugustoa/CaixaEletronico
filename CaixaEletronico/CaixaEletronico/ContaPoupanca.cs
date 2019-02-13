using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum_CaixaEletronico.Contas;

namespace Caelum_CaixaEletronico
{
    class ContaPoupanca : Conta , Tributavel
    {

        // override , para avisar o compilador que estamos sobreescrevendo um metodo ja feito
        public override void Saca (double valor)
        {
            if(valor <= 0)
            {
                // Exception mais especifica
                throw new ArgumentException();
            }

            if(this.Saldo >= valor)
            {
                this.Saldo -= valor + 0.1;
               
            }else
            {
                // se saque não der certo , quero jogar uma nova exeção
                throw new SaldoInsuficienteException(); 
            }
            
        }

       public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}

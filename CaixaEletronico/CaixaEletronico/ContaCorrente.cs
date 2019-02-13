using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum_CaixaEletronico.Contas;

namespace Caelum_CaixaEletronico
{
    class ContaCorrente : Conta
    {

        //Static diz que ele pertence a classe ContaConrrente , ou seja vai ser global para 
        // cada objeto ContaCorrente Criado. vai ser o mesmo.
        public static int TotalDeContas { get; private set; }

        public ContaCorrente()
        {
            ContaCorrente.TotalDeContas++;
        }
        
        public static int ProximaNumeroDeContas()
        {
            return ContaCorrente.TotalDeContas + 1;
        }


        public override void Saca(double valor)
        {
            if( valor <= 0)
            {
                throw new ArgumentException();
            }
            
            if(this.Saldo >= valor)
            {
                this.Saldo -= valor - 0.1;
            }
            else
            {
                throw new SaldoInsuficienteException();
            }
        }
    }
}

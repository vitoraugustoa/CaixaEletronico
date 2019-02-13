using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum_CaixaEletronico.Contas
{
   public abstract class Conta
    {
        public int Numero { get; set; } // propriedade


        // 'protected' para que as classes filhas possam acesar o saldo da conta 
        public double Saldo { get; protected set; } // <-- propriedade ( encapsulamento )

        public string Titular { get; set; } // propriedade


        // 'virtual' permite que o metodo saca seja sobrescrito em uma classe filha
        // abstratct transforma o metodo somente como se fosse uma ideia, que precisa de uma implementação
        // toda classe filha de Conta , que não for abstract , precisa ter uma implementacao para o metodo saca
        public abstract void Saca(double valorAserSacado);
       

        public void Deposita (double valorAserDepositado)
        {
            if (valorAserDepositado > 0)
            {
                this.Saldo += valorAserDepositado;
            }
        }

        public void Transfere (double valorAserTransferido , Conta destino)
        {
            if (this.Saldo >= valorAserTransferido)
            {
                this.Saca(valorAserTransferido);
                destino.Deposita(valorAserTransferido);
            }
        }

        
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum_CaixaEletronico
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(Tributavel conta)
        {
            this.Total += conta.CalculaTributo();
        }
    }
}

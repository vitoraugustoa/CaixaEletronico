﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum_CaixaEletronico
{
    class GerenciadorDeImposto
    {
        public double Total { get; private set; }

        public void Adiciona(Tributavel contaTributavel)
        {
            this.Total += contaTributavel.CalculaTributo();
        }
    }
}

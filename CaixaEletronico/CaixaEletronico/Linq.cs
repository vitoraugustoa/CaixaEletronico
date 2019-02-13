using Caelum_CaixaEletronico.Contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caelum_CaixaEletronico;

namespace CaixaEletronico
{
    public partial class Linq : Form
    {
        public Linq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var novasContas = new List<Conta>();

            Conta c1 = new ContaCorrente();
            c1.Deposita(2500);

            Conta c2 = new ContaPoupanca();
            c2.Deposita(2300);

            Conta c3 = new ContaInvestimento();
            c3.Deposita(1400);

            novasContas.Add(c1);
            novasContas.Add(c2);
            novasContas.Add(c3);

            // LINQ Language Intagrated Query
            var filtradas = from c in novasContas
                            where c.Saldo > 2000
                            select c;

            // LAMBDA é uma função que recebe um elemnto de uma lista
            double saldoTotal = filtradas.Sum(c => c.Saldo);
            MessageBox.Show(string.Format("O Saldo total é : {0}", saldoTotal));

        }

        private void Linq_Load(object sender, EventArgs e)
        {

        }
    }
}

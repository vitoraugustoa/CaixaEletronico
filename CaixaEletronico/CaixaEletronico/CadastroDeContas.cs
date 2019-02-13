using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caelum_CaixaEletronico.Contas;
using Caelum_CaixaEletronico;

namespace CaixaEletronico
{
    public partial class CadastroDeContas : Form
    {
        
        private Form1 aplicacaoPrincipal; // Criamos uma variavel do tipo Form1 

        public CadastroDeContas(Form1 aplicacaoPrincipal) // Puxamos um paramentro do tipo Form1 - aplicacaoPrincipal
        {
            // A nossa variavel , recebe a variavel buscada via parametro
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
            boxTipoConta.Items.Add("Corrente");
            boxTipoConta.Items.Add("Poupanca");
            boxTipoConta.Items.Add("Investimento");
        }
       
        //Ao clicar no button cadastrar
        private void button1_Click(object sender, EventArgs e)
        {
          

            // é criada duas variaveis , e ambas recebem o valor digitado pelo usuario
            string titular = titularDaConta.Text;
            int numero = Convert.ToInt32(numeroDaConta.Text);
            string tipoConta = boxTipoConta.Text;

            

            Util.LimparCampos(this.Controls);

            if(tipoConta == "Investimento")
            {
                Conta contaInvestimento = new ContaInvestimento()
                {
                    Numero = numero,
                   Titular = titular
                };


                this.aplicacaoPrincipal.AdicionaConta(contaInvestimento);
            }else if(tipoConta == "Poupanca")
            {
                Conta contaPoupanca = new ContaPoupanca()
                {
                    Numero = numero,
                    Titular = titular
                };

                this.aplicacaoPrincipal.AdicionaConta(contaPoupanca);
            }else
            {
                // Cria-se uma nova conta do tipo Corrente
                Conta contaCorrente = new ContaCorrente()
                {
                    // Aqui as variaveis da conta , recebem os valores recebidos pelo usuario
                    Numero = numero,
                    Titular = titular

                };

                // aqui usamos nossa variavel , para puxar a função AdicionaConta , onde a conta é adicionada no vetor
                this.aplicacaoPrincipal.AdicionaConta(contaCorrente);
                // Aqui usamos novamente nossa variavel , para puxar uma função que limpa os textos digitados.
            }






        }
    }
}

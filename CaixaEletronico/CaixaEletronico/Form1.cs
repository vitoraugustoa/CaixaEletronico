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
using CaixaEletronico;

namespace Caelum_CaixaEletronico
{

    public partial class Form1 : Form
    {
        // int de quantidade de contas para haver melhor controle
        // cria uma lista que armazena o tipo Conta
        List<Conta> listaDeContas = new List<Conta>();

        // Aqui é a função para limpar os campos de Texto
        public void LimpaTexto(TextBox texto)
        {
            texto.Text = string.Empty;
        }




        public Form1()
        {
            InitializeComponent();
        }


        //
        private void Form1_Load(object sender, EventArgs e)
        {

            foreach(Conta teste in listaDeContas)
            {
                boxContas.Items.Add(teste.Titular);

            }
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            double valorDeposita = Convert.ToDouble(valorText.Text);

            listaDeContas[boxContas.SelectedIndex].Deposita(valorDeposita);
            //contaSelecionada.Deposita(valorDeposita);

            saldoDaContaText.Text = Convert.ToString(listaDeContas[boxContas.SelectedIndex].Saldo);

            LimpaTexto(valorText);
        }

        private void boxContas_SelectedIndexChanged(object sender, EventArgs e)
        {

           // Conta contaSelecionada = listaDeContas[boxContas.SelectedIndex];

            numeroContaText.Text = Convert.ToString(listaDeContas[boxContas.SelectedIndex].Numero);
            titularDaContaText.Text = listaDeContas[boxContas.SelectedIndex].Titular;
            saldoDaContaText.Text = Convert.ToString(listaDeContas[boxContas.SelectedIndex].Saldo);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void AdicionaConta(Conta conta)
        {
            this.listaDeContas.Add(conta);

            boxContas.Items.Add(conta.Titular);
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = listaDeContas[boxContas.SelectedIndex];

            double valorSaca = Convert.ToDouble(valorText.Text);

            contaSelecionada.Saca(valorSaca);

            saldoDaContaText.Text = Convert.ToString(contaSelecionada.Saldo);

            LimpaTexto(valorText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroDeContas cadastro = new CadastroDeContas(this);
            cadastro.ShowDialog();
        }

        private void btn_RemoveConta_Click(object sender, EventArgs e)
        {
            listaDeContas.RemoveAt(boxContas.SelectedIndex);
            
            boxContas.Items.Clear();

            foreach(Conta atualizada in listaDeContas)
            {
                boxContas.Items.Add(atualizada.Titular);
            }

            Util.ClearForm(this);
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTeste paginaDeTestes = new FormTeste();
            paginaDeTestes.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Linq LINQ = new Linq();
            LINQ.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conta".Pluralize());
        }
    }
}

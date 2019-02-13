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
using System.IO;

namespace CaixaEletronico
{
    public partial class FormTeste : Form
    {
        public FormTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // usamos o modo Create para escrevermos.
            Stream saida = File.Open("Entrada.txt", FileMode.Create);
            // StreamWriter é para escrever
            StreamWriter escritor = new StreamWriter(saida);
            escritor.Write(txt_texto.Text);

            escritor.Close();
            saida.Close();

        }

        private void FormTeste_Load(object sender, EventArgs e)
        {
            // Verifica se o arquivo esta vazio
            if (File.Exists("Entrada.txt"))
            {
                // Variavel do tipo Stream que pega bits.
                // abrimos o arquivo com a Classe  'File' e o metodo 'open' , e escolhemos o modo Open
                Stream entrada = File.Open("Entrada.txt", FileMode.Open);
                // O leitor do tipo StreamReader , vai 'Traduzir' a variavel entrada
                StreamReader leitor = new StreamReader(entrada);
                // a string linha vai receber a linha contida dentro do leitor com o ReadLine()
                string linha = leitor.ReadLine();
                //Enquanto a linha nao estiver vazia
                while (linha != null)
                {
                    // o componente texto concatena a linha
                    txt_texto.Text += linha;
                    // e a linha recebe a proxima linha lida pela ReadLine()
                    linha = leitor.ReadLine();
                }
                // depois fechamos tanto o leitor quanto a entrada.
                leitor.Close();
                entrada.Close();
            }
            
        }
    }
    // HashSet uma lista que não permite repetição de elementos.
    // em um HashSet não tem posição definida para cada elemento.
    /*
   int idade = 24;
   string nome = "Guilherme";
   string texto = string.Format("Ola {0} A sua idade é : {1} ",nome,idade);

   // Split separa uma variavel de acordo com um char que escolher.
   string menssagem = "Guilherme,42,Sao Paulo,Brasil";
   string[] partes = menssagem.Split(',');

   // Colocar em letras maiusculas
   string curso = "tn11";
   curso = curso.ToUpper();

   // metodo replace para subistituir uma parte da string por outra
   string sala = "sala 13";
   sala = sala.Replace('1', '3');

   // Quebrar um texto baseado pelo numero de caracter
   // ou retornar a posicao de uma caracter de um texto

   string nomeCompleto = "Vitor Augusto";
   string primeiroNome = nomeCompleto.Substring(0, 5);
   string segundoNome = nomeCompleto.Substring(6, 7);

   // ou retornar o index da string

   int posicaoA = nomeCompleto.IndexOf('A');
   string segundoNome2 = nomeCompleto.Substring(posicaoA);

   */

}

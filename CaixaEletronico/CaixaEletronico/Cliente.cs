using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum_CaixaEletronico
{
    //A classe Objet é Pai de todas as classes do C#
    // Os metodos da classe Objet sempre precisa ser reescrevido em todas as classes
    // caso queira utilizalos.
    class Cliente
    {
        public string Nome { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public string Endereco { get; set; }

        public int Idade { get; set; }

        public Cliente (string nome)
        {
            this.Nome = nome;
        }

        public Cliente()
        {

        }
        // Metodo Equals serve para comparar duas instancias
        // METODO Equals compara o conteudo 
        // ja o simbulo == compara a referencia
        // Sobrescrevendo o metodo Equals da Classe Objet
        public override bool Equals(object obj)
        {
            //Convertenado o "obj" para tipo Cliente atraves da operação de Casting
            Cliente cliente = (Cliente)obj;
            //Comparando esse RG com o Rg do objeto passado.
            return this.Rg.Equals(cliente.Rg);
        }
        
        // Metodo To String , serve para transformar uma classe em String
        public override string ToString()
        {
            return "Cliente Nome  " + this.Nome + "\n Cliente RG " + this.Rg;
        }


        public bool EhMaiorDeIdade()
        {
            if (this.Idade >= 18)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoObrigatorioFinal.entidades
{
    class ContratoPessoaJuridica : Contrato
    {
        public int Cnpj { get; set; }
        public string Inscricao { get; set; }
        public int Numero { get; set; }
        public string Contratante { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set; }
        public double Prestacao { get; set; }


        public ContratoPessoaJuridica()
        {

        }


        public ContratoPessoaJuridica(int cnpj, string inscricao, int numero, string contratante, double valor, int prazo)
        {
            Cnpj = cnpj;
            Inscricao = inscricao;
            Numero = numero;
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;
        }

        public double CalcularPrestação()
        {
            Prestacao = Valor / Prazo + 3;
            return Prestacao;
        }

        public void exibirInfo()
        {
            Console.WriteLine("Nome: {0}, Valor do contrato: {1}, Prazo: {2}, Valor prestacao: {3}", Contratante, Valor, Prazo, Prestacao);
        }

    }
}

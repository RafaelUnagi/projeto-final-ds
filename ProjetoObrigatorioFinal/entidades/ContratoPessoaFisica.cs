using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoObrigatorioFinal.entidades
{
    class ContratoPessoaFisica : Contrato
    {
        public int Cpf { get; set; }
        public int Idade { get; set; }
        public int Numero { get; set; }
        public string Contratante { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set; }
        public double Prestacao { get; set; }


        public ContratoPessoaFisica()
        {

        }

        public ContratoPessoaFisica(int cpf, int idade, int numero, string contratante, double valor, int prazo)
        {
            Cpf = cpf;
            Idade = idade;
            Numero = numero;
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;
        }


        public double CalcularPrestação()
        {
            Console.WriteLine("Qual sua idade: ");
            Idade = int.Parse(Console.ReadLine());

            if (Idade <= 30)
            {
                Prestacao = Valor / Prazo + 1;
            }
            else if (Idade <= 40)
            {
                Prestacao = Valor / Prazo + 2;
            }
            else if (Idade <= 50)
            {
                Prestacao = Valor / Prazo + 3;
            }
            else
            {
                Prestacao = Valor / Prazo + 4;
            }


            return Prestacao;
        }

        public void exibirInfo()
        {
            Console.WriteLine("Nome: {0}, Valor do contrato: {1}, Prazo: {2}, Valor prestacao: {3}, Idade: {4}", Contratante, Valor, Prazo, Prestacao, Idade);

        }


    }
}

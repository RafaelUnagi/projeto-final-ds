using System;
using ProjetoObrigatorioFinal.entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoObrigatorioFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            ContratoPessoaJuridica pessoaJuridica = new ContratoPessoaJuridica();
            ContratoPessoaFisica pessoaFisica = new ContratoPessoaFisica();

            Console.WriteLine("----Contrato-----");
            Console.WriteLine("Contrato Pessoa (Jurídica ou Física) j/f: ");
            char ch = char.Parse(Console.ReadLine());

            pessoaJuridica.Cnpj = 123123;
            pessoaJuridica.Inscricao = "Essa mesmo";
            pessoaJuridica.Numero = 666;
            pessoaJuridica.Contratante = "Retcheeee";
            pessoaJuridica.Valor = 40000;
            pessoaJuridica.Prazo = 4;

            pessoaFisica.Cpf = 90969;
            pessoaFisica.Numero = 777;
            pessoaFisica.Contratante = "Jê";
            pessoaFisica.Valor = 40000;
            pessoaFisica.Prazo = 4;

            double prestacao;

            if (ch == 'j')
            {
                prestacao = pessoaJuridica.CalcularPrestação();
                pessoaJuridica.exibirInfo();
            }

            else if (ch == 'f')
            {
                prestacao = pessoaFisica.CalcularPrestação();
                pessoaFisica.exibirInfo();
            }

            Console.ReadLine();
        }
    }
}

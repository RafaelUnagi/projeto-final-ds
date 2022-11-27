using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoObrigatorioFinal.entidades
{
    class Contrato
    {
        public int Numero { get; set; }
        public string Contratante { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set; }
        public double Prestacao { get; set; }

        public Contrato()
        {

        }

        public Contrato(int numero, string contratante, double valor, int prazo)
        {
            Numero = numero;
            Contratante = contratante;
            Numero = numero;
            Valor = valor;
            Prazo = prazo;
        }

        public double CalcularPrestação()
        {
            return CalcularPrestação();
        }



    }
}

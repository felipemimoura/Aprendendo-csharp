using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(string messagem): base(messagem) { }
        public SaldoInsuficienteException(string menssagem, Exception excecaoInterna) : base(menssagem, excecaoInterna) { }

        public SaldoInsuficienteException(double saldo, double valorSaque) : this("Tentativa de saque no valor de " + valorSaque + " em uma conta saldo de  "  + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

    }
}

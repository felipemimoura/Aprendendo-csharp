// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {

        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int Numero { get;}
        public int Agencia { get; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciaNaoPermitidos { get; private set; }



        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            if(agencia <= 0)
            {
                ArgumentException execao = new ArgumentException("A Agencia deve ser maior do que 0.", nameof(agencia));
                throw execao;
            } 

            if(numero <= 0)
            {
                ArgumentException execao = new ArgumentException("O número deve ser maior do que 0.", nameof(numero));
                throw execao;
            }


            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException("Saldo Insuficiente para o saque no valor de " + valor);
            }

            _saldo -= valor;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
             Sacar(valor);

            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciaNaoPermitidos++;
                throw new OperacaoFinanceiraException("Operação não realizada", ex);
            }

            contaDestino.Depositar(valor);
          
        }
    }
}

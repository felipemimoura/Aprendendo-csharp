using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(12312, 123);
                ContaCorrente conta2 = new ContaCorrente(23412, 456);

                conta2.Depositar(100);
                conta.Depositar(150);
                
               

                conta2.Transferir(500, conta);
            }
    
            catch(OperacaoFinanceiraException ex)
            {
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

          
            Console.ReadLine();

        }     
        
    }

}

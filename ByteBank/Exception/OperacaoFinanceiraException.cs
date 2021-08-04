using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException() { }
        public OperacaoFinanceiraException(string menssagem) { }

        public OperacaoFinanceiraException(string menssagem, Exception excecaoInterna): base(menssagem, excecaoInterna ) { }
    }
}

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

        public OperacaoFinanceiraException(string menssagem) : base(menssagem){ }

        public OperacaoFinanceiraException(string menssagem, Exception excecaInterna) : base(menssagem, excecaInterna) { }
    }
}

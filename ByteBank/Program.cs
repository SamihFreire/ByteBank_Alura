using ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(20129, 29293939);

                ContaCorrente conta2 = new ContaCorrente(32323, 22222);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(1000);

            }
            catch( OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna)");

                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);
            }
            
            Console.ReadLine();
        }
    }
}

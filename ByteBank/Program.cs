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
            ContaCorrente conta = new ContaCorrente(754, 54645213);

            Console.WriteLine("Taxa de operação: " + ContaCorrente.TaxaOperacao);

            Console.ReadLine();
        }
    }
}

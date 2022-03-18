using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.nome = "Guilherme";
            cliente.CPF = "434.564.879-20";
            cliente.profissao = "Desenvolvedor C#";

            conta.Titular = cliente;
            conta.Agencia = 563;
            conta.Numero = 56321855;
            conta.Saldo = 4900.31;

            Console.WriteLine("Cliente: " + conta.Titular.nome);
            Console.WriteLine("Agencia: " + conta.Agencia);
            Console.WriteLine("Número: " + conta.Numero);
            Console.WriteLine("Saldo: " + conta.Saldo);

            Console.ReadLine();
        }
    }
}

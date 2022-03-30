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
                ContaCorrente conta = new ContaCorrente(55555, 555);

                ContaCorrente conta2 = new ContaCorrente(4645, 5454);

                conta2.Transferir(-10, conta);


                conta.Depositar(50);

                Console.WriteLine("Saldo: " + conta.Saldo);

                conta.Sacar(-500);

                Console.WriteLine("Saldo: " + conta.Saldo);
            }
            catch (ArgumentException ex)
            {

                if(ex.ParamName == "numero")
                {

                }

                Console.WriteLine("Paremtro com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Execeção do tipo SaldoInsuficienteException");
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}

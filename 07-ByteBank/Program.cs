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

            Console.WriteLine("Total de Contas Criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine("__________________________________________");

            ContaCorrente conta1 = new ContaCorrente(867, 86712540); //Criado o contrutor da classe, fica necessario instanciar junto com os valores solicitados por 
            Cliente cliente1 = new Cliente("Jonas", "Desenvolvedor C#", "021.234.989-01");
            conta1.Titular = cliente1;
            
            //conta1.Numero = 86712540;  
            //conta1.Agencia = 867;
            //conta1.Agencia = -10;

            Console.WriteLine("Nome: " + conta1.Titular.nome);
            Console.WriteLine("Profissão: " + conta1.Titular.profissao);
            Console.WriteLine("CPF: " + conta1.Titular.CPF);
            Console.WriteLine("Agencia: " + conta1.Agencia);
            Console.WriteLine("Numero: " + conta1.Numero);

            Console.WriteLine("Total de Contas Criadas: " + ContaCorrente.TotalDeContasCriadas);  //Teste se esta contando correto a odem de criação, ideal seria colocar apenas no final esse total;

            Console.WriteLine("__________________________________________");

            ContaCorrente conta2 = new ContaCorrente(868, 78236874);
            Cliente cliente2 = new Cliente("Laila", "Gerente", "012.345.323-12");
            conta2.Titular = cliente2;

            Console.WriteLine("Nome: " + conta2.Titular.nome);
            Console.WriteLine("Profissão: " + conta2.Titular.profissao);
            Console.WriteLine("CPF: " + conta2.Titular.CPF);
            Console.WriteLine("Agencia: " + conta2.Agencia);
            Console.WriteLine("Numero: " + conta2.Numero);

            Console.WriteLine("Total de Contas Criadas: " + ContaCorrente.TotalDeContasCriadas);
            
            Console.WriteLine("__________________________________________");

            Console.ReadLine();
        }
    }
}

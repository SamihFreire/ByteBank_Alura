using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception  //Criando uma classe de exceção
    {
        public double Saldo { get; }
        public double ValorSaque { get; set; }

        public SaldoInsuficienteException() { } //Contrutor sem argumentos
        public SaldoInsuficienteException(string mensagem) : base(mensagem) //Passando para o contrutor da classe Exception a menssagem
        {

        }
                                                                                //Passando para o contrutor dessa classe a mensagem, + poderia passar direto para a BASE
        public SaldoInsuficienteException(double saldo, double valorSaque) : this("Tentativa de saque do valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

    }
}

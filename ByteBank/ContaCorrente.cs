using ByteBank;
using System;
using System.Net.NetworkInformation;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public Cliente Titular { get; set; }       
        public static int TotalDeContasCriadas { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciaNaoPermitidas { get; private set; }

        public int Agencia { get;  }

        public int Numero { get; } //Aqui temos apenas o GET onde o SET se torna apenas de leitura, ou definido como READONLY, sendo visivel apenas no CONSTRUTOR

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
            if(agencia <= 0)
            {
                //string texto = nameof(numeroAgencia);  // string texto esta recebendo a string "numeroAgencia";

                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }
            if(numero<= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if(this._saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            this._saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
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
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciaNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação nao realizada.", ex);
            }
            

            contaDestino.Depositar(valor);
        }
    }
}
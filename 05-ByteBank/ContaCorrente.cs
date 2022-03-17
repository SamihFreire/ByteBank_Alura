//using _05_ByteBank; --Tornas-se desnecessário a utilização desse using pois ja foi defenido: namespace _05_ByteBank

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public _05_ByteBank.Cliente titular; //Como mencionado acima, caso queira posso retirar o namespace _05_ByteBank pois já criado em cima
        public int agencia;
        public int numero;
        public double saldo = 100;

        public bool Sacar(double valor)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
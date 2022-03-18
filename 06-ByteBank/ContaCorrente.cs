//using _06_ByteBank; --Tornas-se desnecessário a utilização desse using pois ja foi defenido: namespace _06_ByteBank

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        //private _06_ByteBank.Cliente _titular;   //Como mencionado acima, caso queira posso retirar o namespace _06_ByteBank pois já criado em cima
        public Cliente Titular { get; set; }       //Como nao existe uma lógica realizando atividades, basta simplificar dessa forma
        public int Agencia { get; set; }
        public int Numero { get; set; }
        
        private double _saldo = 100;               //Utilizo _ para delimitar se é uma variavel privada, para facilitar o reconhecimento

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
                else
                {
                    _saldo = value;
                }
            }
        }
        public bool Sacar(double valor)
        {
            if(this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
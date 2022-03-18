//using _07_ByteBank; --Tornas-se desnecessário a utilização desse using pois ja foi defenido: namespace _06_ByteBank

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        //private _07_ByteBank.Cliente _titular;   //Como mencionado acima, caso queira posso retirar o namespace _06_ByteBank pois já criado em cima
        public Cliente Titular { get; set; }       //Como nao existe uma lógica realizando atividades, basta simplificar dessa forma

        //Defnindo uma propriedade STATIC, significa que essa propriedade que pertence a todos dessa classe
        //todos os objetos instanciados dessa classe compartilham essa informação;
        //Diferente de uma caracteristica criada, Ex:Saldo, que é individual de cada objeto instanciado
        //STATIC trata-se de uma CARACTERISTICA da CLASSE, NÂO dos OBJETOS!
        public static int TotalDeContasCriadas { get; private set; }

        private int _agencia;
        public int Agencia 
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
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
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
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
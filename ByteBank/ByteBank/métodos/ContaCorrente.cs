// using _005_ByteBank;

namespace _007_ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }


        public Cliente Titular { get; set; }

        public static int SetDeContasCriadas { get; private set; }

        public static int GetTotalDeContasCriadas()
        {
            return SetDeContasCriadas;
        }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
            }
        }
        public int Numero { get; set; }


        public int agencia;
        public int numero;
        private double _saldo = 100;


        public double Saldo
        {
            get //obter
            {
                return _saldo;
            }
            set //definir
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public void SetSaldo(double saldo)
        {

        }

        public double GetSaldo()
        {
            return _saldo;
        }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30 / SetDeContasCriadas;

            SetDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }


    }

}





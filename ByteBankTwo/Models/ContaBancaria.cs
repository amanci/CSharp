namespace Byte_Bank_2.Models
{
    public abstract class ContaBancaria
    {  
        public int Agencia;
        
        public int Conta;
        public string Titular;
        public double _Saldo;

        public ContaBancaria(int agencia, int numeroConta, string titular){ 
            this.Agencia = agencia;
            this.Conta = numeroConta;
            this.Titular = titular;
            this._Saldo = 0.0;
        }

        public bool VerificarSaldo (double saldo) {
            if (saldo < 0) {
                return false;
            } else {
                this._Saldo = saldo;
                return true;
            }
        }

        public abstract bool Saque(double valorSaque);

        public double Deposito (double valorDeposito) {

            if (valorDeposito < 0) {
                System.Console.WriteLine ("DEPÓSITO NEGATIVO");
            } else {
                this._Saldo = this._Saldo + valorDeposito;
                System.Console.WriteLine ("DEPÓSITO REALIZADO");
            }

            return this._Saldo;
        }

        public bool Transferencia (ContaBancaria contaDestino, double valor) {
            if (this.Saque (valor)) {
                contaDestino.Deposito (valor);

                return true;
            } else {
                return false;
            }
        } 
    }
}
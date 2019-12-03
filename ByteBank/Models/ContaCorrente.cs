using System;
using ByteBank.Models;

namespace ByteBank.Models {
    public class ContaCorrente {
        public Clientes Titular { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        private double _Saldo;

        public double Saldo {

            get { return _Saldo; }

        }

        public ContaCorrente (int agencia, int numeroConta, Clientes titular) {
            this.Agencia = agencia;
            this.NumeroConta = NumeroConta;
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

        public double Deposito (double deposito) {

            if (deposito < 0) {
                System.Console.WriteLine ("DEPÓSITO NEGATIVO");
            } else {
                this._Saldo = this._Saldo + deposito;
                System.Console.WriteLine ("DEPÓSITO REALIZADO");
            }

            return this._Saldo;
        }

        public bool Saque (double saque) {

            bool controleSaque = false;

            if (saque < 0) {
                controleSaque = false;
            } else {
                this._Saldo = this._Saldo - saque;
                if (this._Saldo < 0) {
                    controleSaque = false;
                } else {
                    controleSaque = true;
                }
            }

            return controleSaque;
        }

        public bool Transferencia (ContaCorrente contaDestino, double valor) {
            if (this.Saque (valor)) {
                contaDestino.Deposito (valor);

                return true;
            } else {
                return false;
            }
        }
    }
}
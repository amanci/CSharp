using System.Globalization;
namespace Byte_Bank_2.Models
{
    public class ContaEspecial : ContaBancaria
    {
        public double Limite;
        public ContaEspecial(int Agencia, int Conta, string Titular): base(Agencia, Conta, Titular){

            this.Limite = 0;

        }

        public override bool Saque(double valorSaque)
        {
           bool controleSaque = false;

            if (valorSaque < 0) {
                controleSaque = false;
            } else {
                this._Saldo = this._Saldo - valorSaque;
                if (this._Saldo < 0) {
                    controleSaque = false;
                } else {
                    controleSaque = true;
                }
            }

            return controleSaque;
        }

        public bool SetLimite(double novoLimite){

            if(novoLimite >= 0){
                this.Limite = novoLimite;

                return true;
            }

            return false;
        }
    }
}


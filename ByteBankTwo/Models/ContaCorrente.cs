namespace Byte_Bank_2.Models
{
    public class ContaCorrente : ContaBancaria
    {
       
        public ContaCorrente (int Agencia, int Conta, string Titular): base(Agencia, Conta, Titular){


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
    }
}
namespace _29.Models
{
    public class Registro
    {
        private string  _Nome;
        private string _Telefone;
        private string _Aniversario;


        public string GetSetNome {
            get { return _Nome; }
            set { _Nome = value; }
        }
        public string GetSetTelefone {
            get { return _Telefone; }
            set { _Telefone = value; }
        }
        public string GetSetAniversario {
            get { return _Aniversario; }
            set { _Aniversario = value; }
        }
        public Registro(string nome, string telefone, string aniversario){

            this._Nome = nome;
            this._Telefone = telefone;
            this._Aniversario = aniversario;
        }
    }
}
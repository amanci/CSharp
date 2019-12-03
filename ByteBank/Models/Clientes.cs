namespace ByteBank.Models {
    public class Clientes {
        private string _Cpf;
        private string _Nome;
        private string _Email;
        private string _Senha;

        public string Cpf {
            get { return _Cpf; }
            set { _Cpf = value; }
        }

        public string Nome {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Email {
            get { return _Email; }
            set { _Email = value; }
        }

        public string Senha {
            get { return _Senha; }
            set { _Senha = value; }
        }

        public Clientes (string cpf, string nome, string email) {
            this._Cpf = cpf;
            this._Nome = nome;
            this._Email = email;
        }

        public bool TrocarSenha (string senha) {
            if (senha.Length >= 6 && senha.Length <= 16) {
                this._Senha = senha;
                return true;
            } else {
                return false;
            }
        }
    }
}
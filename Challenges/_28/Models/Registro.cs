namespace _28.Models
{
    public class Registro
    {
        private string Nome;
        private string Telefone;
        private string Aniversario;

        public Registro(){

        }


        public Registro(string nome, string telefone, string aniversario){
            
            this.Nome = nome;
            this.Telefone = telefone;
            this.Aniversario = aniversario;
        }
    }
}
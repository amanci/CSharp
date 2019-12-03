namespace ByteBank.Models {
    public class Pessoas {
        public Pessoas () {
            System.Console.WriteLine ("CONSTRUTOR 1 INICIALIZADO");
        }
        public Pessoas (string nome) {
            System.Console.WriteLine ($"CONSTRUTOR 2 INICIALIZADO + {nome}");
        }

        public static void PegarNome (string Nome, out string sobreNome) {
            sobreNome = "FERREIRA";
        }
    }
}
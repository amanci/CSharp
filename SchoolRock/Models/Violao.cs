using System;
using SchoolRock.Interfaces;

namespace SchoolRock.Models
{
    public class Violao : InstrumentoMusical, IHarmonia, IMelodia, IPercussao
    {
        public bool MaterRitmo()
        {
            System.Console.WriteLine("MATENDO O RITMO DO VIOLÃO");

            return true;
        }

        public bool TocarAcordes(){
            System.Console.WriteLine("TOCANDO ACORDES DO VIOLÃO");

            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("SOLANDO VIOLÃO");

            return true;
        }
    }
}
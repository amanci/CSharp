using System;
using SchoolRock.Interfaces;

namespace SchoolRock.Models
{
    public class ContraBaixo: InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool MaterRitmo()
        {
            System.Console.WriteLine("MANTER RITMO DO CONTRA-BAIXO");

            return true;
        }

        public bool TocarAcordes(){
            System.Console.WriteLine("TOCANDO ACORDES DE CONTRA-BAIXO");

            return true;
        }
    }
}
using System;
using SchoolRock.Interfaces;

namespace SchoolRock.Models
{
    public class Baixo: InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool MaterRitmo()
        {
            System.Console.WriteLine("MATENDO RITMO DA BATERIA");

            return true;
        }
        

        public bool TocarAcordes(){
            System.Console.WriteLine("TOCANDO ACORDES DE BAIXO");

            return true;
        }
    }
}
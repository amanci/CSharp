using System;
using SchoolRock.Interfaces;


namespace SchoolRock.Models

{
    public class Guitarra: InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes(){
            System.Console.WriteLine("TOCANDO ACORDES DE GUITARRA");

            return true;
        }

        public bool TocarSolo(){

            System.Console.WriteLine("TOCANDO SOLO DE GUITARRA");

            return true;
        }

    }
}
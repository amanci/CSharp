using System;
using SchoolRock.Interfaces;

namespace SchoolRock.Models
{
    public class Bateria : InstrumentoMusical, IPercussao
    {
        public bool MaterRitmo()
        {
            System.Console.WriteLine("MANTER RITMO DA BATERIA");

            return true;
        }
    }
}
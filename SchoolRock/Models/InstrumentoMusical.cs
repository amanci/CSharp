using System;
using System.Collections.Generic;
 
namespace SchoolRock.Models
{
    public class InstrumentoMusical
    {
        string[] Notas = {"DÓ", "RÉ", "MI", "FA", "SOL", "LÁ", "SI"};

        public string TocarMusica(){

            int indexNota = new Random().Next(Notas.Length - 1);
            
            return Notas[indexNota];
        }

    }
}
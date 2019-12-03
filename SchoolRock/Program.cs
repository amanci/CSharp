using System;
using SchoolRock.Models;

namespace SchoolRock
{


    
    class Program
    {
        static void Main(string[] args)
        {

            InstrumentoMusical instrumentoGenerico = new InstrumentoMusical();
            System.Console.WriteLine(instrumentoGenerico.TocarMusica());

            Violao violao1 = new Violao();

            System.Console.WriteLine("VIOLÃO: "+ violao1.TocarMusica());
            violao1.TocarAcordes();

        }
    }
}

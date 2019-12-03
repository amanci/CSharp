using System;
using System.Collections;
using System.Collections.Generic;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string sair = "";
            List<string> listaNomes = new List<string>();
                        
            do{
                System.Console.Write("NOME: ");
                nome = Console.ReadLine().ToUpper();
                System.Console.WriteLine("APERTE A TECLA | X | PARA SAIR");
                sair = Console.ReadLine().ToUpper();

                listaNomes.Add(nome);
            } while(nome != "X");

            System.Console.WriteLine("QTD NOMES: "+ listaNomes.Count);
        }
    }
}

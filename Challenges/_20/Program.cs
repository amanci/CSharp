using System;
using System.Collections;
using System.Collections.Generic;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random numAleatorio = new Random();
            int[] arrayNum = new int[10];
            List<int> numPar = new List<int>();
            List<int> numImpar = new List<int>();
            string exibirPar = "";
            string exibirImpar = "";
            

            for (int i = 0 ; i < arrayNum.Length ; i++){
                int num = numAleatorio.Next(1, 100);
                arrayNum[i] = num;
            }

            foreach (var num in arrayNum){
                if (num % 2 == 0){
                
                exibirPar = exibirPar +  num + " - ";

                numPar.Add(num);
                } else {
                    numImpar.Add(num);

                    exibirImpar = exibirImpar +  num + " - ";
                }
            }

            System.Console.WriteLine("NUMEROS PARES: "+ exibirPar);
            System.Console.WriteLine("NUMEROS ÍMPARES: "+ exibirImpar);
        }
    }
}

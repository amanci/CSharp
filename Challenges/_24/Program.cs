using System;

namespace _24 {
    class Program {
        static void Main (string[] args) {
            Random numRandom = new Random ();

            int[] arrayNum1 = new int[10];
            int[] arrayNum2 = new int[10];
            int[] arrayNum3 = new int[10];
            string exibicao = "";

            for (int i = 0; i < arrayNum1.Length; i++) {

                arrayNum1[i] = numRandom.Next (1, 500);

                arrayNum2[i] = numRandom.Next (1, 100);

                arrayNum3[i] = arrayNum1[i] + arrayNum2[i];
            }

            
            foreach (var exibicaoArray in arrayNum1) {
                System.Console.Write ($"{exibicaoArray} | ");
            }

            System.Console.WriteLine();
            System.Console.WriteLine ("===== LISTA 1 =====");

            foreach (var exibicaoArray in arrayNum2) {
                System.Console.Write ($"{exibicaoArray} | ");
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine ("===== LISTA 2 =====");

            foreach (var exibicaoArray in arrayNum3) {
                System.Console.Write ($"{exibicaoArray} | ");
            }

            System.Console.WriteLine();
            System.Console.WriteLine ("===== LISTA 3 =====");
        }
    }
}
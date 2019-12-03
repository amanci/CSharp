using System;

namespace Kahoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matriz = {
                {10, 15,48},
                {56, 97, 77},
                {2, 100, 33}
            };

            for(int i = 0; i < matriz.GetLength(0); i++){

                for(int i2 = 0; i2 < matriz.GetLength(1 ); i2++){

                    matriz[i, i2] = matriz[i, i2] + matriz [i, i2];

                    System.Console.WriteLine(matriz);

                }


            }
        }
    }
}

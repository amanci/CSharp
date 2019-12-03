using System;

namespace ShowTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0;
            int quantity = 0;
       
            string symbol = "*";
         
            Console.Write("QUANTIDADE: ");
            quantity = int.Parse(Console.ReadLine());

            Console.Write("ALTURA: ");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 0; i < quantity; i++){ 
                string show = "";

                for(int i2 = 0; i2 < h; i2++){
                        Console.WriteLine($"{show = show + symbol}");
                }

                Console.WriteLine("");

            }
        }
    }
}

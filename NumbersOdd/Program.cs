using System;

namespace NumbersOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            System.Console.Write("WHILE: ");

            while(i <= 99){
                System.Console.Write(i +" ");

                i = i + 2;
            }

            System.Console.WriteLine("");

            System.Console.Write("FOR: ");

            for(i = 1; i <= 99; i = i + 2)
                System.Console.Write(i +" ");
        }
    }
}
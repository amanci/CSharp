using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 0;
            int Num2 = 0;
    
            System.Console.Write("1° NÚMERO: ");
            Num1 = int.Parse(Console.ReadLine());

            System.Console.Write("2° NÚMERO: ");
            Num2 = int.Parse(Console.ReadLine());

            // CONCATENAÇÃO

            Console.WriteLine("");
            Console.WriteLine("*****CONCATENAÇÃO*****");
            Console.WriteLine("");
        
            Console.WriteLine (Num1+" + "+Num2+" = "+(Num1 + Num2));
            Console.WriteLine (Num1+" - "+Num2+" = "+(Num1 - Num2));
            Console.WriteLine (Num1+" * "+Num2+" = "+(Num1 * Num2));
            Console.WriteLine (Num1+" / "+Num2+" = "+(Num1 / Num2));
            Console.WriteLine (Num1+" % "+Num2+" = "+(Num1 % Num2));
            
            // INTERPOLAÇÃO

            Console.WriteLine("");
            Console.WriteLine("*****INTERPOLAÇÃO*****");
            Console.WriteLine("");

            Console.WriteLine($"{Num1} + {Num2} = {Num1 + Num2}");
            Console.WriteLine($"{Num1} - {Num2} = {Num1 - Num2}");
            Console.WriteLine($"{Num1} * {Num2} = {Num1 * Num2}");
            Console.WriteLine($"{Num1} / {Num2} = {Num1 / Num2}");
            Console.WriteLine($"{Num1} % {Num2} = {Num1 % Num2}");
        }
    }
}

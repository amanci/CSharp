using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 0;
            int Num2 = 0;
            int option;

            
            Console.Write(" |1| ADIÇÃO (+)\n |2| SUBTRAÇÃO (-)\n |3| MULTIPLICAÇÃO (*)\n |4| DIVISÃO (/)\n |5| RESTO (5)\n");

            Console.Write("\nSELECIONE A OPERAÇÃO DESEJADA: ");
            option = int.Parse(System.Console.ReadLine());

            Console.Write("\nDIGITE O 1° NÚMERO: ");
            Num1 = int.Parse(System.Console.ReadLine());

            Console.Write("\nDIGITE O 2° NÚMERO: ");
            Num2 = int.Parse(System.Console.ReadLine());

        /*      EXEMPLO: ESTRUTURA CONDICIONAL ANINHADA

            if(option == 1){
                Console.WriteLine($"{Num1} + {Num2} = {Num1 + Num2}");
            }
            else if(option == 2){
                Console.WriteLine($"{Num1} - {Num2} = {Num1 - Num2}");
            }
            else if (option == 3){
                Console.WriteLine($"{Num1} * {Num2} = {Num1 * Num2}");
            }
            else if (option == 4){
                Console.WriteLine($"{Num1} / {Num2} = {Num1 / Num2}");
            }
            else if (option == 5){
                Console.WriteLine($"{Num1} % {Num2} = {Num1 % Num2}");
            }
            else{
                Console.WriteLine("OPÇÃO INVÁLIDA");
            }

        */
            switch(option){
                case 1:
                Console.WriteLine($"{Num1} + {Num2} = {Num1 + Num2}");
                break;

                case 2:
                Console.WriteLine($"{Num1} - {Num2} = {Num1 - Num2}");
                break;

                case 3:
                Console.WriteLine($"{Num1} * {Num2} = {Num1 * Num2}");
                break;

                case 4:
                Console.WriteLine($"{Num1} / {Num2} = {Num1 / Num2}");
                break;

                case 5:
                Console.WriteLine($"{Num1} % {Num2} = {Num1 % Num2}");
                break;

                default:
                Console.WriteLine("OPÇÃO INVÁLIDA");
                break;
            }   
        }
    }
}

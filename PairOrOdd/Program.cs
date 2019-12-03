using System;

namespace PairOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            char option = '@';

    /* 
            while(option != 'S' &&  option != 's'){ 
                System.Console.Write("DIGITE O NÚMERO DESEJADO: ");
                number = int.Parse(Console.ReadLine());

                if(number % 2 == 0)
                {
                    System.Console.WriteLine("É PAR");
                }

                else
                {
                    System.Console.WriteLine("É ÍMPAR");
                }

                System.Console.Write("APERTE A TECLA (S) SE QUISER SAIR | APERTE TECLA (C) SE QUISER CONTINUAR: ");
                option = char.Parse(Console.ReadLine());

                    if(option == 'S' && option == 's'){
                        System.Console.WriteLine("VOCÊ SAIU DO PROGRAMA!");
                    }
    */

         do{
                System.Console.Write("DIGITE O NÚMERO DESEJADO: ");
                number = int.Parse(Console.ReadLine());

                if(number % 2 == 0)
                {
                    System.Console.WriteLine("É PAR");
                }

                else
                {
                    System.Console.WriteLine("É ÍMPAR");
                }

                System.Console.Write("APERTE A TECLA (S) SE QUISER SAIR | APERTE TECLA (C) SE QUISER CONTINUAR: ");
                option = char.Parse(Console.ReadLine());

                    if(option == 'S' && option == 's'){
                        System.Console.WriteLine("VOCÊ SAIU DO PROGRAMA!");
                    }

            } while (option == 'S' && option == 's');

            }
        }
    }

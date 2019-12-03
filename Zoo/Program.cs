using System;
using System.Collections;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {



        static void ExibirMenu(){
            System.Console.WriteLine("=================");
            System.Console.WriteLine("=== ZOOLÓGICO ===");
            System.Console.WriteLine("=================");
            System.Console.WriteLine();


            bool whileControle = false;
            int menuOpcao = -1;
            string menuSair = "";

            do{
                System.Console.WriteLine("[1] TUBARAÃO MARTELO");
                System.Console.WriteLine("[2] TUCANO");
                System.Console.WriteLine();
                System.Console.Write("OPÇÃO: ");
                menuOpcao = int.Parse(Console.ReadLine());
                System.Console.WriteLine();

                System.Console.WriteLine("DESEJA CONTINUAR? [S / N}");
                System.Console.WriteLine();
                System.Console.Write("S OU N: ");
                menuSair = Console.ReadLine().ToUpper();

                if (menuSair == "S"){
                    whileControle = true;
                }
                




            }while (!whileControle);

            
        }
        static void Main(string[] args)
        {
            ExibirMenu();
        }


    }
}

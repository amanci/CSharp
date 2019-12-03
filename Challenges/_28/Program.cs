using System;
using _28.Models;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string telefone = "";
            string aniversario = "";
            string opcao = "";
            bool controle = false;
            
            
            do{
                System.Console.WriteLine("NOME: ");
                nome = Console.ReadLine();

                System.Console.WriteLine("TELEFONE: ");
                telefone = Console.ReadLine();

                System.Console.WriteLine("ANIVERSÁRIO: ");
                aniversario = Console.ReadLine();

                System.Console.WriteLine("DESEJA CONTINUAR? \n S / N :");
                opcao = Console.ReadLine();
                opcao.ToUpper();


                if(opcao == "N"){
                    controle = true;
                }

                Registro reg = new Registro (nome, telefone, aniversario);

            } while(controle != true);
            
        }
    }
}

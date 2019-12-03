using System;
using System.Collections.Generic;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SELECIONE O LIXO A SER EVIADO PARA RECICLAGEM:");
            System.Console.WriteLine("1 - PAPELÃO");

            System.Console.WriteLine("DIGITE O CÓDIGO: ");
            int menuLixo = int.Parse(Console.ReadLine());   

            Reciclar(Lixeira.lixos[menuLixo]);   
        }

        private static void Reciclar(Lixo lixo){

            Type tipoLixo = lixo.GetType().GetInterface("IAzul");
            
            if (tipoLixo.Equals(typeof(IAzul))){

                IAzul lixoConvertido = (IAzul)lixo;
                Console.BackgroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"{lixoConvertido.MensagemReciclagemAzul()} DEVE IR PARA A LIXEIRA AZUL");
                Console.ResetColor();
            }
        }
    }
}

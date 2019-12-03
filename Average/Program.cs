using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double Nota1;
            double Nota2;
            double Nota3;
            double Nota4;
            double Media;

            Console.Write("DIGITE A 1° NOTA DO ALUNO: ");
            Nota1 = double.Parse(Console.ReadLine());

            Console.Write("DIGITE A 2° NOTA DO ALUNO: ");
            Nota2 = double.Parse(Console.ReadLine());

            Console.Write("DIGITE A 3° NOTA DO ALUNO: ");
            Nota3 = double.Parse(Console.ReadLine());

            Console.Write("DIGITE A 4° NOTA DO ALUNO: ");
            Nota4 = double.Parse(Console.ReadLine());

            Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            Console.WriteLine("MÉDIA DO ALUNO: "+Media);

            if (Media >= 7.0){
                Console.WriteLine("APROVADO! VOCÊ É MONSTRO!");
            }   else{
                Console.WriteLine("REPROVADO! VOCÊ É CARLOS!");
                }
        }
    }
}

using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary, salaryReadjusted;

            System.Console.Write("INFORME SEU SALÁRIO: R$ ");
            salary = double.Parse(Console.ReadLine());

            if(salary < 500){
                System.Console.WriteLine("SALÁRIO SEM REAJUSTE: R$ "+salary);
                salaryReadjusted = salary * 1.3;
                System.Console.WriteLine("SALÁRIO COM REAJUSTE: R$ "+salaryReadjusted);
            }   else{
                    System.Console.WriteLine("SEU SALÁRIO NÃO SE APLICA A REGRA");  
                }
        }
    }
}

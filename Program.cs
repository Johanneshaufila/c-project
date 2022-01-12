using System;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the name of the employee: ");
            string name = Console.ReadLine();

            Console.Write("Enter the age of the employee: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the salary of the employee: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            double anualSalary = salary * 12;
            int ageIn5years = age + 5;
            double salaryIn5years = anualSalary * 5;
            double deductedTax = 15 / 100;
            double totalDeducted = deductedTax * salary;

            Console.WriteLine("---------------------Employee information--------------------------");
            Console.WriteLine("1. The employee nme is             :" + name);
            Console.WriteLine("1. The employee age  is            :" + age);
            Console.WriteLine("1. The employee salary per month is:" + salary);

            Console.WriteLine("---------------------Employee Salary info--------------------------");
            Console.WriteLine("1. The employee annual salary is   :" + anualSalary);
            Console.WriteLine("1. The employee age  in 5 years    :" + ageIn5years);
            Console.WriteLine("1. The employee salary in 5 years  :" + salaryIn5years);
            Console.WriteLine("1. The employee tax per month      :" + totalDeducted);
            Console.ReadKey();




        }
    }
}

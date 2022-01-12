using System;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your Name: ");
            string name = Console.ReadLine();

            Console.Write("Please Enter Your AGE: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Name for John is: " + name);
            Console.WriteLine("The age for John is: " + age);
            Console.Read();
        }
    }
}

using System;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();   
            Console.WriteLine("Hello "+name+ " !");
            Console.WriteLine("Enter your age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age " + age +" .");




            Console.ReadLine();
        }
    }
}

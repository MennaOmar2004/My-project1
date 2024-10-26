using System;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();   
            Console.WriteLine("Enter your age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is :  " + name+"\n"+"your age is : " +age);





            Console.ReadLine();
        }
    }
}

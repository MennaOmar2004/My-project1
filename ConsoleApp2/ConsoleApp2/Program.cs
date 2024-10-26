using System;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first num");
            string firstnum = Console.ReadLine();
            Console.WriteLine("Enter the second num");
            string secndnum = Console.ReadLine();
            int result = int.Parse(firstnum) + int.Parse(secndnum);
            Console.WriteLine("result = "+result);

            Console.WriteLine("----------------------");

            Console.WriteLine(" enter your age");
            int age =int.Parse( Console.ReadLine());
            if (age <= 18) Console.WriteLine("child");
            else if(age>18 & age<20)
            {
               Console.WriteLine("teenager");
            }
            else {
                Console.WriteLine("adult");
            }
        }
    }
}

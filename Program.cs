// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        bool x = true;
        while (x == true)
        {
            Console.WriteLine("Enter an Option: ");
            string option = Console.ReadLine();

            if (option == "add")
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine()); 
                int sum = a + b;
                Console.WriteLine("Answer = " + sum);
                
            }

            else if (option == "sub")
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int sub = a - b;
                Console.WriteLine("Answer = " + sub);
                
            }

            else if (option == "div")
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                double div = a / b;
                Console.WriteLine("Answer = " + div);
                
            }

            else if (option == "mult")
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int mult = a * b;
                Console.WriteLine("Answer = " + mult);
                
            }

            else
            {
                Console.WriteLine("Exiting Program");
                break;
            }
        }
    }
}

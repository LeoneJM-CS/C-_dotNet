using System;

namespace ClassWork1
{
	internal class ClassWork1()
	{
		static void Main(string[] args)
		{
			/*bool x = true;
			while (x == true)
			{
				Console.WriteLine("Enter a Grade: ");
				String grade = Console.ReadLine();
				if (grade == "A")
				{
					Console.WriteLine("Excellent\n");
                }
				else if (grade == "B")
				{
					Console.WriteLine("Very Good\n");                 
                }
				else if (grade == "C")
				{
					Console.WriteLine("Good\n");                   
                }
				else if (grade == "D")
				{
					Console.WriteLine("Work Hard\n");						
				}
				else if (grade == "E")
				{
					Console.WriteLine("Poor\n");                  
                }
				else if (grade == "F")
				{
					Console.WriteLine("Very Poor\n");                  
                }
				else
				{
					x = false;
				}
            }*/

			Console.WriteLine("Enter a Number: ");
			int days = Convert.ToInt32(Console.ReadLine());
			int years = 0;
			int weeks = 0;
			while (days >= 7)
			{
				if (days >= 365)
				{
					days -= 365;
					years++;
				}
				else if (days >= 7)
				{
					days -= 7;
					weeks++;
				}
			}
            Console.WriteLine("Years: " + years);
            Console.WriteLine("Weeks: " + weeks);
            Console.WriteLine("Days: " + days);
			Console.ReadLine();
        }
	}
}

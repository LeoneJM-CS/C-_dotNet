using System;

namespace Class1
{
	internal class Class1
	{
		static void Main(string[] args)
		{
			int balance = 1000;
			bool x = true;
			while (x == true) 
			{
				Console.WriteLine("Welcome to the ATM \n");
                Console.WriteLine("1. Check Balance \n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Quit \n");
				Console.WriteLine("Enter option: ");
				int option = Convert.ToInt32(Console.ReadLine());

				if (option == 1)
				{
					Console.WriteLine("Current Balance: {0} \n", balance);
				}
				else if (option == 2)
				{
					Console.WriteLine("Enter ammount you want to withdraw: ");
					int withdraw = Convert.ToInt32(Console.ReadLine());
					if ((withdraw > 0) && (withdraw < balance))
					{
						balance -= withdraw;
					}
					else
					{
						Console.WriteLine("Insufficiant funds \n");
					}
				}
				else if (option == 3)
				{
					Console.WriteLine("Enter ammount to deposit: ");
					int deposit = Convert.ToInt32(Console.ReadLine());
					if (deposit > 0)
					{
						balance += deposit;
					}
					else
					{
                        Console.WriteLine("Cannot Deposit {0} amount \n", deposit);
                    }
				}
				else if (option == 4)
				{
					Console.WriteLine("Exiting Program");
					x = false;
				}
				else
				{
                    Console.WriteLine("Please Enter Valid Input \n");
                }
            }
		}
	}
}

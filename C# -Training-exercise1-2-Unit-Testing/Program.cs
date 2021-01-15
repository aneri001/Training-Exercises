using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
	class Program
	{
		static void Main(string[] args)
		{


			Console.Title = "exercise";
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.WriteLine("Hello");
			Console.WriteLine("Enter input based on choice");
			Console.WriteLine("1 for electricity bill calculation");
			Console.WriteLine("2 for  adding using Generic Function");
			Console.WriteLine("3 for Sorting list using Linq");
			Console.WriteLine("4 for extension method");

			Console.BackgroundColor = ConsoleColor.Black;

			// Wait for Enter key to be pressed.
			var input = int.Parse(Console.ReadLine());


			switch (input)
			{
				case 1:
					//calculating electricity bill
					Console.WriteLine("***** Electricity bill Generation *****");
					exe1_billgenerator bill = new exe1_billgenerator();
					bill.GetCustomerData();
					Console.ReadLine();
					break;

				case 2:
					//calculating generiic function
					Console.WriteLine("***** Generic  Function *****\n");
					exe2 gen1 = new exe2();
					gen1.add_generic<int>(13, 14);
					gen1.add_generic<string>("hello", "Interns");
					break;
				case 3:
					//Sorting list using Linq
					Console.WriteLine("***** Generic  Function *****\n");
					exe2 gen2 = new exe2();
					gen2.sort_linq();
				
					break;

				case 4:
					//Sorting list using Linq
					Console.WriteLine("***** Extensible Methods*****\n");
					exe2 gen3 = new exe2();
					gen3.GetValueorDefault(null);
					gen3.GetValueorDefault(344343);

					break;
				default:
					break;
			}
		}
	}
}
//@Aneri Adani
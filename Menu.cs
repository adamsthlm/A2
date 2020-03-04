/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/

using System;
using System.Collections.Generic;
using System.Text;
namespace A2
{
    class Menu
    {
		public void Start()
		{
			int choice = -1;

			while (choice != 0)
			{
				WriteMenuText(); // show the menu
								 // Read user choice
				try
				{
					choice = int.Parse(Console.ReadLine());

				}
				catch (FormatException) { }
				

				// Depending on the value fo the choice, create an
				// instance of the class displayed on the menu

				switch (choice)
				{
					case 1: // menu item 1 (The for-statement)
						{
							WholeNumbersForAdd sumObj = new WholeNumbersForAdd();
							sumObj.Start();
							break;
						}
					case 2: //menu item 2 (a while-loop)
						{
							FloatingNumbersWhileAdd fnwa_object = new FloatingNumbersWhileAdd();
							fnwa_object.Start();
							break;
						}
					case 3: //menu no help class with while-loop instansiated here! 2020-03-04
						{
							CurrencyConverter curConv = new CurrencyConverter();
							curConv.Start();
							break;
						}
					case 4: //menu item 4
						{
							Console.Write(" ** You have pressed 4 ** NOT implemented yet");
							break;
						}
					case 5: //menu item 5
						{
							Console.Write(" ** You have pressed 5 ** NOT implemented yet");
							break;
						}
					case 0: //menu item 0
						{
							Console.Write(" ** You have pressed 0 ** NOT implemented yet");
							break;
						}
					default:
						{
							Console.WriteLine($"Invalid Input, pleade try againg ({choice})");
							Console.ReadKey();
							break;
						}
				}

			}



		}

		private void WriteMenuText()
		{

			Console.Clear();
			Console.Write("\n----------------------------------------------------------------------");
			Console.Write("\n                           MAIN MENU                                  ");
			Console.Write("\n----------------------------------------------------------------------");
			Console.Write("\n        Whole numbers with FOR                                     : 1");
			Console.Write("\n        Floating poin numbers with WHILE                           : 2");
			Console.Write("\n        Currency converter with DO WHILE LOOP                      : 3");
			Console.Write("\n        Work shedule                                               : 4");
			Console.Write("\n        Temperature table                                          : 5");
			Console.Write("\n                                                                      ");
			Console.Write("\n        Exit the program                                           : 0");
			Console.WriteLine();

		}
	}
}

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
				Console.Clear();

			}



		}

		private void WriteMenuText()
		{

			Console.Clear();
			Console.Write("----------------------------------------------------------------------");
			Console.Write("                           MAIN MENU                                  ");
			Console.Write("----------------------------------------------------------------------");
			Console.Write("             Whole numbers with FOR                              : 1  ");
			Console.Write("             Floating poin numbers with WHILE                    : 2  ");
			Console.Write("             Currency converter with DO WHILE LOOP               : 3  ");
			Console.Write("             Work shedule                                        : 4  ");
			Console.Write("             Temperature table                                   : 5  ");
			Console.Write("                                                                      ");
			Console.Write("             Exit the program                                    : 0  ");

		}
	}
}

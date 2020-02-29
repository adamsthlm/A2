/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/


using System;

namespace A2
{
    class WholeNumbersForAdd
    {

        // int number;
        //public void-method that preforms the whole process
        public void Start()
        {
            // Call the method which writes the program info, title, etc.
            WriteProgramInfo();
            ReadInput(WriteProgramInfo());
            SumNumber();
            ShowResults();
            Console.ReadLine();
        }

        private void ShowResults()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Nästa metod att inplementera
        /// </summary>
        /// <returns>Sum of numbers chosen</returns>

        private long SumNumber()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ReadInput reads a key from user and evaluate it. If its a number return it else make
        /// user try again
        /// then summs the numbers and returns them.
        /// </summary>
        private bool keyOk; // manage ReadInput while loop
        private int userInput;

        private int ReadInput(int sizeOf)
        {
            int x = 0;
            int[] theNumbers = new int[sizeOf];
            for (int i = WriteProgramInfo(); i < WriteProgramInfo(); i++)
            {

                theNumbers[i] = Input();
            }
            for (int i = WriteProgramInfo(); i < WriteProgramInfo(); i++)
            {
                x += theNumbers[i];
            }


            return x;
        }

        public int WriteProgramInfo()
        {
            Console.WriteLine();
            Console.Write("\n***** Summation of whole numbers ******");
            Console.Write("\n       using a for statement \n\n----------------------------------------");
            Console.Write("\nHow many numbers would you like to add? ");
            int numberOfNumbersToAdd = int.Parse(Console.ReadLine());
            return numberOfNumbersToAdd;

        }
        private int Input()
        {
            while (keyOk == false)
            {
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    return userInput;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a number!");
                    keyOk = false;
                    return -1;
                }
            }
            return -1;
        }

    } // end class
} // end namespace 

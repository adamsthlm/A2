/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/


using System;

namespace A2
{
    /// <summary>
    /// class WholeNumberForAdd, reads input from user and present the sum using a for-loop
    /// </summary>
    class WholeNumbersForAdd
    {

        private int sum;
        private int numOfInput;

        //public void-method that preforms the whole process
        public void Start()
        {
            // Call the method which writes the program info, title, etc.
            WriteProgramInfo();
            ReadInput();
            SumNumber();
            ShowResults();
            Console.ReadLine();
        }


        /// <summary>
        /// Presents the result to the user
        /// </summary>
        private void ShowResults()
        {

            // prints the result to the console window
            Console.WriteLine("\n----------------------------");

            Console.WriteLine("The sum is \t{0}", sum);


        }

        /// <summary>
        /// This method reads and adds the number to variable sum
        /// </summary>
        /// <returns>Sum of numbers chosen</returns>

        private void SumNumber()
        {

            for (int i = 0; i < numOfInput; i++)
            {
                Console.WriteLine("\nEnter number " + i + " :");

                sum += int.Parse(Console.ReadLine());


            }
        }


        private int userInput;
        private bool keyOk;

        private void ReadInput()
        {
            // determin how many numbers there are to bed added

            Console.WriteLine("\nNumber of values to be added? ");
            numOfInput = Input();
            if (numOfInput == -1)
            {
                Console.WriteLine("You have made an illegal input, please try again...");
                ReadInput();
            }

        }


        /// <summary>
        /// Writes programinfo to console
        /// </summary>
        public void WriteProgramInfo()
        {
            Console.WriteLine();
            Console.Write("\n***** Summation of whole numbers ******");
            Console.Write("\n       using a for statement \n\n----------------------------------------");

        }

        /// <summary>
        /// Input checks if valid int else make notice to user
        /// If I get time i will extract this method and make it a class to use for the VG grade
        /// </summary>
        /// <returns>Valid user input</returns>

        private int Input()
        {
            while (keyOk == false)
            {
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    keyOk = true;
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

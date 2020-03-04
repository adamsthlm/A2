/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/


using System;

namespace A2
{
    /// <summary>
    /// class FloatingNumbersWhileAdd, reads numbers from user and adds them using a while-loop
    /// untill user presses 0 and the program returns to the menu
    /// </summary>
    public class FloatingNumbersWhileAdd
    {
        private double input;
        double sum;

        //Declare a variable (aka field, instancevariable or attribute
        public void Start()
        {
            // Call the metod wich writes the prigraminfo, title, etc.
            WriteProgramInfo();
            ReadInputAndSumNumbers();
            ShowResults();

        }

        /// <summary>
        /// displays the sum to the user
        /// </summary>
        private void ShowResults()
        {
            Console.WriteLine("The sum is : " + sum);
        }

        /// <summary>
        /// this is where the magic happens, the while loop wont stop untill 
        /// the user presses 0
        /// </summary>
        private void ReadInputAndSumNumbers()
        {
            // read number. If the valu is give as 0, end the iteration
            // otherwise accumelate the results in the instans-variable sum
            bool done = false;

            while (!done)
            {

                // here its possibel to 
                Console.Write("Write an amount to sum or zero to finish...");
                input = double.Parse(Console.ReadLine());
                if (input.Equals(0))
                {
                    done = true;
                }
                else
                {

                    sum += input;
                    ShowResults();

                }

            }


        }

        /// <summary>
        /// a short pressentation of what the program is doing
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine();
            Console.Write("\n***** Summation of real numbers ******");
            Console.Write("\n       using a while loop \n\n----------" +
                "------------------------------");
            Console.WriteLine(); 
        }


        private double ReadInput()
        {
            Console.Write("Write an amount to sum or zero to finish...");
            double num = double.Parse(Console.ReadLine());
            return num;

        }
    } // end class
} // end namespace



/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/


using System;

namespace A2
{
    public class FloatingNumbersWhileAdd
    {
        private int input;
        double sum;

        //Declare a variable (aka field, instancevariable or attribute
        public void Start()
        {
            // Call the metod wich writes the prigraminfo, title, etc.
            WriteProgramInfo();
            ReadInputAndSumNumbers();
            ShowResults();

        }

        private void ShowResults()
        {
            Console.WriteLine("The sum is : " + sum);
        }

        // 
        private void ReadInputAndSumNumbers()
        {
            // read number. If the valu is give as 0, end the iteration
            // otherwise accumelate the results in the instans-variable sum
            bool done = false;

            while (!done)
            {
                input = int.Parse(Console.ReadLine());
                if (input.Equals(0))
                {
                    done = true;
                }
                else
                {

                    sum += input;
                }

            }
            Console.WriteLine("The sum is: " + sum);


        }

        // Write welcome text to user
        private void WriteProgramInfo()
        {
            Console.WriteLine();
            Console.Write("\n***** Summation of real numbers ******");
            Console.Write("\n       using a while loop \n\n----------" +
                "------------------------------" + "\n Write 0 to finish!");
        }
        private double ReadInput()
        {
            Console.Write("Write an amount to sum or zero to finish...");
            double num = double.Parse(Console.ReadLine());
            return num;

        }
    } // end class
} // end namespace

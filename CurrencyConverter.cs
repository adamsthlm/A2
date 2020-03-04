using System;

namespace A2
{
    class CurrencyConverter
    {
        private double input;
        private double sum;
        private string curName;
        private float rate;

        public void Start()
        {
            // Call the method which writes the program info, title, etc.
            WriteProgramInfo();
            ReadInputAndConvertCurrency();
            ShowResults();
            Console.ReadLine();
        }

        private void ShowResults()
        {
            Console.WriteLine("Converting from " + curName + " at " + rate + "\n----------------------" +
                "------------------------------------\n" + "The sum is: " + sum * rate);


        }

        private void ReadInputAndConvertCurrency()
        {
            // read number. If the valu is give as 0, end the iteration
            // otherwise accumelate the results in the instans-variable sum
            bool done = false;

            do

            {
                Console.Write("Write an amount to convert or zero to finish...");
                input = double.Parse(Console.ReadLine());
                if (input.Equals(0))
                {
                    done = true;
                }
                else
                {
                    sum += input;
                }


            } while (!done);

            Console.WriteLine("Enter the name of the currency you want to exchange: ");
            curName = Console.ReadLine();
            Console.WriteLine("Enter the the excange rate for this currency: ");
            rate = float.Parse(Console.ReadLine());


        }

        /// <summary>
        /// a short pressentation of what the program is doing
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine();
            Console.Write("\n***** Currency converter ******");
            Console.Write("\n       using a do-while loop \n\n----------" +
                "------------------------------");
            Console.WriteLine();
        }
    }
}

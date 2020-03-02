using System;

namespace A2
{
    public class FloatingNumbersWhileAdd
    {
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
            throw new NotImplementedException();
        }

        // 
        private void ReadInputAndSumNumbers()
        {
            // read number. If the valu is give as 0, end the iteration
            // otherwise accumelate the results in the instans-variable sum
            bool done = false;

            while (!done)
            {
                // ADD YOUR CODE HERE
            }

            
           // throw new NotImplementedException();
        }

        // Write welcome text to user
        private void WriteProgramInfo()
        {
            throw new NotImplementedException();
        }
        private double ReadInput()
        {
            Console.Write("Write an amount to sum or zero to finish...");
            double num = double.Parse(Console.ReadLine());
            return num;
            
        }
    } // end class
} // end namespace

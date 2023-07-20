using System.Threading.Channels;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operator precedence is the processing executing the preferred operator first followed by the other operators.
            /* Comparison operators
          *
          * used to compare values or variables
          * helps to make a decision
          * boolean values ( true , false)
          *
          == Equal to
         !=  Not Equal
           >  Greater than
            < Less than
            >= Greater than or equal to
            <= Less than or equal to
          */
            //  Console.WriteLine(2==3);
            //  Console.WriteLine(2!=3);
            //bool result = (2 == 3);
            //Console.WriteLine(result);
            //Console.WriteLine(5*(6-2));
            //// * - + /
            //// / > * > + > -
            ///

            Console.WriteLine("Enter the first number:" );
            string input1 = Console.ReadLine( );

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            int firstNumber =  Convert.ToInt32(input1);
            int secondNumber =  Convert.ToInt32(input2);


            Console.WriteLine(firstNumber == secondNumber);
            Console.WriteLine(firstNumber != secondNumber);
            Console.WriteLine(firstNumber > secondNumber);
            Console.WriteLine(firstNumber < secondNumber);
            Console.WriteLine(firstNumber >= secondNumber);
            Console.WriteLine(firstNumber <= secondNumber);

        }

    }
}

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            //If statement
            // if ( expression) // condition
            //{
            // statement block
            //}
            if (number == 2)
            {​​​​​
                Console.WriteLine("Yes");
            }​​​​​
            else
            {​​​​​
                Console.WriteLine("No");
            }​​​​​
        }
    }
}
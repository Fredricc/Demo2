namespace AcceptTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string? input1 = Console.ReadLine();

            Console.WriteLine("Enter the second number");
            string? input2 = Console.ReadLine();

            int firstNumber = Convert.ToInt32(input1);
            int secondNumber = Convert.ToInt32(input2);

            int sum = firstNumber + secondNumber;

            if(firstNumber == 0 && secondNumber == 0)
            {
                Console.WriteLine("Both the numbers are zero");
            }
            else if(firstNumber <= 0)
            {
                Console.WriteLine("First number is negative");
            }
            else if (secondNumber <= 0)
            {
                Console.WriteLine("Second number is negative");
            }
            else
            {
                Console.WriteLine($"Sum of first number and second number is {sum}");
            }
        }
    }
}
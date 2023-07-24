namespace OddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string? input1 = Console.ReadLine();
            int firstNumber = Convert.ToInt32(input1);

            int reminder = firstNumber % 2;

            if (reminder == 1)
            {
                Console.WriteLine("The given number is odd");
            }
            else
            {
                Console.WriteLine("The given number is not odd");
            }
        }
    }
}
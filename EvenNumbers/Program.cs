namespace EvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string? input1 = Console.ReadLine();
            int firstNumber = Convert.ToInt32(input1);

            int reminder = firstNumber % 2;

            if (reminder == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }
    }
}
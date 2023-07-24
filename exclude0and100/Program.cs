namespace exclude0and100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string? input1 = Console.ReadLine();
            int firstNumber = Convert.ToInt32(input1);

            if (firstNumber >= 0 && firstNumber <= 100)
            {
                Console.WriteLine("Number is within 0 to 100.");
            }
            else
            {
                Console.WriteLine("Number is not within 0 to 100.");
            }
        }
    }
}
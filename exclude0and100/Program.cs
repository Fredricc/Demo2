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
                Console.WriteLine("This is the expected input");
            }
            else
            {
                Console.WriteLine("The given number is out of range.");
            }
        }
    }
}
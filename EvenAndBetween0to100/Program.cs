namespace EvenAndBetween0to100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 0 and 100");
            string? input1 = Console.ReadLine();
            int input = Convert.ToInt32(input1);

            int reminder = input % 2;
            if (reminder == 0)
            {
                Console.WriteLine("The given number is even");
                if (input >= 0 && input <= 100)
                {
                    Console.WriteLine("This is the expected input");
                }
                else
                {
                    Console.WriteLine("The given number is out of range.");

                }

            }
            else
            {
                Console.WriteLine("The given number is not even");
                if (input >= 0 && input <= 100)
                {
                    Console.WriteLine("This is the expected input");

                } else
                {
                    Console.WriteLine("The given number is out of range.");

                }
            }
        }
    }
}

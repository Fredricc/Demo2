namespace ReminderIs1or0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 0 and 100");
            string? input1 = Console.ReadLine();
            int input = Convert.ToInt32(input1);

            int reminder = input % 2;
            if (input >= 0 && input <= 100)
                {
                Console.WriteLine("This is the expected input");

                if (reminder == 0)
                    {
                    Console.WriteLine("The reminder is 0");
                    }
                 else if (reminder == 1)
                    {
                        Console.WriteLine("The reminder is 1'");
                    }
                }
            else
            {
                Console.WriteLine("The given number is out of range.");
                if (reminder == 0)
                {
                    Console.WriteLine("The reminder is 0");
                }
                else if (reminder == 1)
                {
                    Console.WriteLine("The reminder is 1'");
                }
            }
        }
    }
}

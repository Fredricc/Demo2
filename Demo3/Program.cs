namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");
            //string input = Console.ReadLine();
            //int number = Convert.ToInt32(input);

            //if (number == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine($"Your number was not zero");
            //}
            //Console.WriteLine("Done");

            // 2/2
            // % -reminder
            //Console.WriteLine(4%2);
            //Console.WriteLine(5%2);
            Console.WriteLine("Enter the number");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            int reminder = number % 2;//getting the reminder
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
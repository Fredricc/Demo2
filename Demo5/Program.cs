namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number?");
            string? input = Console.ReadLine();
            int number  = Convert.ToInt32(input);

            if(number== 4)
            {
                Console.WriteLine($"Your number is {input} and is equal to four.");
            }
            else
            {
                Console.WriteLine($"Your number is {input}");
            }
        }
    }
}
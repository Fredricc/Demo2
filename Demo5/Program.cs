namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you names");
            string? input1 = Console.ReadLine();

            Console.WriteLine( "Enter your ID:");
            string? input2 = Console.ReadLine();

            int id = Convert.ToInt32(input2);
            Console.WriteLine($"Hello {input1} your ID {id} has been added");


        }
    }
}
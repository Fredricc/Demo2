namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your full name");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter your home address:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter your Id");
            string input3 = Console.ReadLine();

            int idNumber = Convert.ToInt32(input3);

            Console.WriteLine($"Mr {input1} your home address is {input2}");
            Console.WriteLine($"Salary is {idNumber * 40}");
        }
    }
}
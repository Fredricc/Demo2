namespace DurationCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Used to represent duration
            Console.WriteLine("Please enter the estimated start date");
            string estimatedStartDate = Console.ReadLine();
            DateTime estimatedStartDateData = Convert.ToDateTime(estimatedStartDate);

            Console.WriteLine("Please enter the actual start date");
            //  string actualStartDate = Console.ReadLine();
            // DateTime actualStartDateData = Convert.ToDateTime(actualStartDate);
            DateTime actualStartDateData = DateTime.Now;

            TimeSpan duration = actualStartDateData - estimatedStartDateData;
            Console.WriteLine($"Days :{duration.Days}");
            Console.WriteLine($"Hours :{duration.Hours}");
            Console.WriteLine($"Minutes :{duration.Minutes}");
            Console.WriteLine($"Seconds :{duration.Seconds}");
        }
    }
}
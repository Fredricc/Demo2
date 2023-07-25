using System.Globalization;

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

            Console.WriteLine("Enter the year");
            string input = Console.ReadLine();
            int year = Convert.ToInt32(input);
            Console.WriteLine(DateTime.IsLeapYear(year));

            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
            Console.WriteLine(DateTime.Now.ToString("yyyy-MMMM-dd"));
            Console.WriteLine(DateTime.Now.ToString(new CultureInfo("en-US")));
            Console.WriteLine(DateTime.Now.ToString(new CultureInfo("en-IN")));
        }
    }
}
namespace Date_Time
{
    public class Program
    {
        static void Main(string[] args)
        {
            double price = 0.0;
            int price1 = 12;
            // price1 =Convert.ToInt32( price); //explicit conversion
            price = price1;
            Console.WriteLine(price);

            string data = price1.ToString();


            string dateData = DateTime.Now.ToLongDateString();
            //Console.WriteLine(dateData);
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Now.ToLongDateString());
            //Console.WriteLine(DateTime.Now.ToShortDateString());
            //Console.WriteLine(DateTime.Now.ToLongTimeString());
            //Console.WriteLine(DateTime.Now.ToShortTimeString());
            //Console.WriteLine(DateTime.Now.Date);
            //Console.WriteLine(DateTime.Now.Year);
            //Console.WriteLine(DateTime.Now.Month);
            //Console.WriteLine(DateTime.Now.Day);
            //Console.WriteLine(DateTime.Now.Hour);
            //Console.WriteLine(DateTime.Now.Minute);
            //Console.WriteLine(DateTime.Now.Second);
            //Console.WriteLine(DateTime.Now.Millisecond);
            // string currentDateTime = DateTime.Now.ToString();
            // Console.WriteLine(currentDateTime);

            DateTime currentDateTime = DateTime.Now;
            int year = currentDateTime.Year;
            Console.WriteLine(year);

            Console.WriteLine("Please enter the estimated start date");
            string estimatedStartDateInput = Console.ReadLine();
            DateTime estimatedStartDate = Convert.ToDateTime(estimatedStartDateInput);

            Console.WriteLine($"Estimated Start Date : {estimatedStartDate.ToString()}");
            DateTime actualStartDate = DateTime.Now;
            DateTime estimatedEndDate = estimatedStartDate.AddDays(90);

            Console.WriteLine($"Estimated End Date : {estimatedEndDate}");
        }
    }
}
namespace Demo_Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for while  do while for each
            //array array list, list<t>
            //1,2,3,4,5 array
            // for each  for

            //run a code multiple times
            // iterate a collection of data and work with it

            //int sum = 0;
            //for (int counter = 1; counter <= 10; counter++)
            //{
            //    sum += counter;
            //        //sum = sum + counter;
            //}
            //Console.WriteLine($"The sum of the first ten numbers is {sum}");
            //Console.ReadLine();

            //Write a program to print all even number between 1 and 10 including 10.
            for( int counter = 0; counter <= 10;  counter++ )
            {
             if ( counter % 2 == 0 )
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}
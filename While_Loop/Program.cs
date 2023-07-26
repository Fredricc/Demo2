namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;

            //while (i <=10)// always
            //{
            //    Console.WriteLine(i);

            //    i++;
            //}

            int i = 0;
            while (true)
            {
                if ( i % 2 == 0)
            {
                Console.WriteLine(i);

            }
                if ( i == 50)
                {
                    break;
                }
               ++ i;
            }

        }
    }
}
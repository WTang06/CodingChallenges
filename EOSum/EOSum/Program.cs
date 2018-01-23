using System;
using System.IO;
using System.Diagnostics;

namespace EOSum
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");

            int n = Convert.ToInt32(reader.ReadLine());

            Stopwatch myStopWatch = new Stopwatch();

            myStopWatch.Start();

            int evensum = 0;
            int oddsum = 0;

            for (int i = 1; i <= n; i++)
            {

                if (n % i == 0)
                {
                    //i is the divisor

                    if (i % 2 == 0)
                    {
                        //is even number

                        evensum += i;

                    }
                    else
                    {
                        //is odd number

                        oddsum += i;

                    }
                }

                myStopWatch.Stop();

                TimeSpan ts = myStopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

                writer.WriteLine("EvenSum = {0}, OddSum = {1}, Stopwatch = {2} ", oddsum, evensum, elapsedTime);
            }

            reader.Close();
            writer.Close();
        }
    }
}

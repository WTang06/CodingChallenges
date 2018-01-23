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

            Stopwatch myStopWatch = new System.Diagnostics.Stopwatch();

            myStopWatch.Start();

            int evensum = 0 + i;
            int oddsum = 0 + i;

            for (int i = 1; i <= n; i++)
            {

                if (n % i == 0)
                {
                    //i is the divisor

                    if (i % 2 == 0)
                    {
                        //is even number
                    }
                    else
                    {
                        //is odd number
                    }
                }

                writer.Write("EvenSum = {0}, OddSum = {1}", evensum, oddsum);
            }

            myStopWatch.Elapsed.Milliseconds.ToString();
        }
    }
}

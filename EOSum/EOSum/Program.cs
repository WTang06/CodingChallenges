﻿using System;
using System.IO;

namespace EOSum
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");

            int n = Convert.ToInt32(reader.ReadLine());

            System.Diagnostics.Stopwatch myStopWatch = new System.Diagnostics.Stopwatch();

            myStopWatch.Start();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (n)
                }
            }

            myStopWatch.Elapsed.Milliseconds.ToString();
        }
    }
}

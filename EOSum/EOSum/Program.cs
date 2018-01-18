using System;
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

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {

                }
            }
        }
    }
}

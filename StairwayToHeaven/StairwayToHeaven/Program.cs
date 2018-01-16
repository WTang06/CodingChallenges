using System;

namespace StairwayToHeaven
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! I will render a staircase for you.");
            Console.WriteLine("");

            Console.WriteLine("What size?");
            int N = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine ();

			string line = "";

			for (int i = 0; i < N; i++) 
			{
				line += "*";

				Console.WriteLine (line);

			}
		}

     }
 }


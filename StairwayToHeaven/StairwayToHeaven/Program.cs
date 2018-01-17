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

			for (int i = 0; i < N; i++) 
			{
				for (int s = 0; s < N ; s++) 
				{
					Console.Write(" ");
				}
				for (int a = 0; a < i; a++) 
				{
					Console.Write("*");
				}

				Console.WriteLine ();

			
			}

		}

     }
 }


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
			int S = N;
			int A = 0;

			for (int i = 0; i < N; i++) 
			{
				for (int j = 0; j < S ; j++) 
				{
					Console.Write(" ");
				}
				for (int k = 0; k < i; k++) 
				{
					Console.Write("*");
				}

				Console.WriteLine ();

				S--;

				A++;
			
			}


		}

     }
 }


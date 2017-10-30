using System;

namespace HighLow
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Random rand = new Random ();
			int num = rand.Next (1, 101);

			Console.WriteLine ("What is your name?");

			string yourName;
			yourName = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine ("Nice to meet you {0}. Let's play a game! I'm thinking of a number between 1 and 100. Type in your guess.", yourName);

            int count = 0;

            int theGuess = 0;
            while (theGuess != num)
            {
                Console.Write("Your Guess: ");
                theGuess = Convert.ToInt32(Console.ReadLine());

                if (theGuess > num)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Lower!");
                }
                else if (theGuess < num)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Higher!");
                }
                count++;
            }
            Console.WriteLine("");
            Console.WriteLine("You got it right! You guessed the number in {0} tries! Goodbye!", count);
	    }
    }
}



using System;

namespace PreWorkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = new int[] { 1,2,3 };
            numberGame();

        }
        static void numberGame()
        {
            Console.WriteLine("Please enter 5 numbers between 1-10, seperated by spaces");
            string usersInput = Console.ReadLine();
            string[] userNumbers = usersInput.Split(' ');
            int[] finalUserNumbers = new int[5];

            for (var i = 0; i < 5; i++)
            {
                finalUserNumbers[i] = int.Parse(userNumbers[i]);
                Console.WriteLine(finalUserNumbers[i].ToString());
            }
            Console.WriteLine("Please choose a number from the following numbers");
            int userChoice = int.Parse(Console.ReadLine());

            int score = 0;
            foreach (int num in finalUserNumbers)
            {
                if (userChoice == num)
                {
                    score++;
                }
            
            }
            Console.WriteLine("The number you selected scored: {0}", userChoice * score);
            Console.ReadLine();
        }
    }
}

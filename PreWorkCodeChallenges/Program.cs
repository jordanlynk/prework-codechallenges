using System;

namespace PreWorkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = new int[] { 8,10,14 };
            // numberGame();
            // leapYearCalc();
            perfectSequence(someArray); 
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
        static void leapYearCalc()
        {
            Console.WriteLine("Please enter in a year, perhaps your favorite?");

            int userInputedYear = int.Parse(Console.ReadLine());

            if (userInputedYear % 4 == 0 && (userInputedYear % 100 != 0 || userInputedYear % 400 == 0))
            {
                Console.WriteLine("That is indeed a Leap Year!!");
            }
            else
            {
                Console.WriteLine("Oooops, that's not a leap year!");
            }
        }
        static void perfectSequence(int[] someArray)
        {
            int sum = 0, prod = 1;

            foreach (int value in someArray)
            {
                sum += value;
                prod += value;
            }

            if(sum == prod)
            {
                Console.WriteLine("Heck yeah");
            }
            else
            {
                Console.WriteLine("Heck no..");
            }
        }
    }
}

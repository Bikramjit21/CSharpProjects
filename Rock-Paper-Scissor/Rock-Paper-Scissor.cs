using System;

namespace Rock_Paper_Scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissor");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Rock:0 Paper:1 Scissor:2");
            Console.Write("Choose a number between 0 and 2: ");

            int userPoint = 0;
            int computerPoint = 0;

            int choice1 = int.Parse(Console.ReadLine());
            Console.WriteLine("You chose "+ choice1);
            Random rand = new Random();
            int choice2 = rand.Next(3);
            Console.WriteLine("Computer Chose "+choice2);

            if (choice1 == 0 && choice2 == 1)
            {
                computerPoint++;
            }
            if (choice1 == 0 && choice2 == 2)
            {
                userPoint++;
            }
            if (choice1 == 1 && choice2 == 2)
            {
                computerPoint++;
            }
            if (choice1 == 1 && choice1 == 0)
            {
                userPoint++;
            }
            if (choice1 == 2 && choice2 == 0)
            {
                computerPoint++;
            }
            if (choice1 == 2 && choice2 == 1)
            {
                userPoint++;
            }

            Console.WriteLine("Your Score "+userPoint +" Computer Score: "+computerPoint);
            if (userPoint == 10)
            {
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("Computer Won");
            }

        }
    }
}

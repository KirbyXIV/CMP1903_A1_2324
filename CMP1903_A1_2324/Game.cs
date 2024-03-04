using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        /// <summary>
        /// This method rolls 3 dice and sums the total
        /// </summary>
        /// <returns></returns>

        List<int> RunningTotalList = new List<int>();

        //Methods

        public void RollDice()
        {
            int RunningSum = 0;
            int Sum = 0;

            for (int i = 1; i <= 3; i++)
            {
                Die Die = new Die();
                int Roll = Die.DieRoll();
                Console.WriteLine($"Roll {i}: {Roll}");
                RunningTotalList.Add(Roll);
                Sum += Roll;
                System.Threading.Thread.Sleep(1);
            }

            foreach (int item in RunningTotalList) { RunningSum += item; }

            Console.WriteLine($"\nSum: {Sum}");
            Console.WriteLine($"Total Sum: {RunningSum}");


        }

        public void ContinueProgram()
        {

            Console.WriteLine("Would you like to roll again..? (Y/N)");
            string UserAnswer = Console.ReadLine();
            
            if (UserAnswer == "Y")
            {
                Console.WriteLine();
                Console.WriteLine("\n3 dice are about to be rolled...");
                Console.WriteLine();

                RollDice();
                ContinueProgram();
            }
            else if (UserAnswer == "N")
            {
                Console.WriteLine("\nThank you :)");
                Console.WriteLine("Click any button to end program...");

            }
            else 
            {
                Console.WriteLine();
                ContinueProgram();

            }
        }

    }
}


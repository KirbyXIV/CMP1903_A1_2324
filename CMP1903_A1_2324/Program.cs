using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        public static void Main()
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            /// <summary>
            /// This method is the main entry point for the application
            /// </summary>
            /// <param name="args"></param>


            Game Game = new Game();
            Testing Test = new Testing();

            Console.WriteLine("3 dice are about to be rolled...");
            
            Console.WriteLine();
            
            Test.TestDie();
            Game.RollDice();

            Game.ContinueProgram();
            
            Console.ReadKey();
            
        }
        
        
    }

}

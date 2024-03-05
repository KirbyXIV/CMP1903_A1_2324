using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method

        /// <summary> 
        /// This method tests the Game class
        /// </summary>

        public void TestDie()
        {
            Die Die = new Die();
            int TestRollSum = 0;

            for (int i = 1; i < 1000; i++)
            {
                int TestRollValue = Die.DieRoll();
                TestRollSum += TestRollValue;
                Debug.Assert(TestRollValue >= 1 && TestRollValue <= 6, "Die roll is out of range");
                Debug.Assert(TestRollSum >= i && TestRollSum <= (6 * i), $"Die roll sum is out of range, roll; {TestRollValue} sum: {TestRollSum}");

            }
        }
        
    }
}

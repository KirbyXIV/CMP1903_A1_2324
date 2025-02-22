﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        /// <summary>
        /// This class should contain one property to hold the current die value,
        /// and one method that rolls the die, returns and integer and takes no parameters.
        /// </summary>
        /// <returns></returns>

        //Property
        
        public int DieValue { get; set; }
        static Random rnd = new Random();

        //Method
        public int DieRoll()
        {
            DieValue = rnd.Next(1, 7);
            return DieValue;
        }
    }
}

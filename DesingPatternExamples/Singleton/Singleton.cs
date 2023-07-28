﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
                Console.WriteLine("Singleton successfully created once");
            }
            else 
            {
                Console.WriteLine("You've already created a singleton");
            }

            return instance;
        }
    }
}

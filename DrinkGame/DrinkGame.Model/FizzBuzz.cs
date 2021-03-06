﻿using System;

namespace DrinkGame
{
    public class FizzBuzz : Game
    {
        private readonly int _fizz;
        private readonly int _buzz;

        public FizzBuzz(int fizz, int buzz)
        {
            _fizz = fizz;
            _buzz = buzz;
        }

        public override void Play(int lim)
        {
            for (int i = 1; i < lim; i++)
            {
                var toPrint = "";
                if (i%_fizz == 0)
                    toPrint += "fizz";
                if (i%_buzz == 0)
                    toPrint += "buzz";
                if (toPrint == "")
                    toPrint = i.ToString();

                Console.Write(toPrint + ",");
            }
        }
    }
}

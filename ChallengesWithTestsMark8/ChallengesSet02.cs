﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0) 
            {
                return true;
            }
            return false; 
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            return true;    
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if ( numbers == null) 
            { 
                return 0; 
            }

            if (numbers.Count() == 0) 
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) 
            { 
                return 0; 
            }

            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            var even = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    even += num;
                }              
            }
            return even;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            return number / 2;
        }
    }
}

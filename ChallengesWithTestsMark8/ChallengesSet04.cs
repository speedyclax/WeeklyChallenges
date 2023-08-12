using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evensSum = numbers.Where(x => x % 2 == 0).Sum();
            var oddsSum = numbers.Where(x => x % 2 != 0).Sum();
            return evensSum - oddsSum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var stringList = new List<string>() { str1, str2, str3, str4 };
            var shortestStr = stringList.Min(x => x.Length);
            return shortestStr;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            var smallestNum = list.Min();
            return smallestNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out var number);
            return isNumber;    

            //bool result = input.Any(x => !char.IsLetter(x));
            //return result;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nulls = objs.Where(x => x == null);
            var others = objs.Where(x => x != null);
            if (nulls.Count() > others.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            var avgEvens = numbers.Where(x => x % 2 == 0);
                        
            if (avgEvens.Count() == 0) 
                return 0;
            
            return avgEvens.Average();
        }

        public int Factorial(int number)
        {
            int i;
            var num = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (i = 1; i <= number; i++)
                 num = num * i;

            return num;
            
        } 
    }
}

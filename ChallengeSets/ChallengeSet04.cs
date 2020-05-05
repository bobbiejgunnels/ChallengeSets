using System;
using System.Linq;
using System.Collections.Generic;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var answer = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    answer += numbers[i];
                }
                if (numbers[i] % 2 != 0)
                {
                    answer -= numbers[i];
                }
            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var a = new List<string>();

            a.Add(str1);
            a.Add(str2);
            a.Add(str3);
            a.Add(str4);

            int answer = str1.Length;
            for (int i = 0; i < a.Count; i++)
            {
                if (answer > a[i].Length)
                {
                    answer = a[i].Length;
                }
            }
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var a = new int[] { number1, number2, number3, number4 };

            var answer = number1;
            for (int i = 0; i < a.Length; i++)
            {
                if (answer > a[i])
                {
                    answer = a[i];
                }

            }
            return answer;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3
                && sideLength2 + sideLength3 > sideLength1
                && sideLength1 + sideLength3 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            double a = 0;

            var answer = double.TryParse(input, out a);
            return answer;


            //if the string is a number return true;
            //if the string is not a number return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int itemCount = objs.Length;
            int nullCount = 0;
            foreach (object obj in objs)
            {
                if (obj == null) nullCount++;
            }
            if (nullCount > itemCount / 2)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int evenSum = 0;
            int evenCount = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                    evenCount++;
                }
            }
            if (evenCount == 0)
            {
                return 0;
            }
            return (double)evenSum / evenCount;
        }
    }

    //public int Factorial(int number)
    //{
    //    if (number < 0)
    //    {
    //        return -1;
    //    }
    //    else if (number == 0)
    //    {
    //        return 1;
    //    }
    //    else
    //    {
    //        return number * Factorial(number - 1);
    //    }
    //}
}


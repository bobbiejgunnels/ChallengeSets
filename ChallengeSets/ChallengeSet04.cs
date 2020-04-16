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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}

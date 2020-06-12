using System.Text;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
           //return vals.All(x => x);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 ==1 || i % 2 ==-1)
                {
                    sum += i;
                }
            }
            if (sum % 2 == 1 || sum % 2 == -1)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsDigit) && password.Any(char.IsLower))
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
           return val[0];
        }

        public char GetLastLetterOfString(string val)
        {

            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            
            if (divisor == 0)
            {
                return 0;
            }
            Decimal value = Decimal.Divide(dividend, divisor); 
            return value;

        }

        public int LastMinusFirst(int[] nums)
        {

            return nums[nums.Length - 1] - nums[0];
           
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50]; 

           for (int i = 0, index = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    odds[index] = i;
                    index++;
                }

            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();

           
        }
    }
}

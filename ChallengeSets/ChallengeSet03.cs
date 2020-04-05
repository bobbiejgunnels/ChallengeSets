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
           return !vals.All(x => x);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
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

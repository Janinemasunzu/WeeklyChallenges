using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool value in vals)
            {
                if (!value)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) 
            {
                return false;
            }
            int sumOfOdds = numbers.Where(n => n % 2 != 0).Sum();
            return sumOfOdds % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            bool hasUppercase = Regex.IsMatch(password, "[A-Z]");
            bool hasLowercase = Regex.IsMatch(password, "[a-z]");
            bool hasNumber = Regex.IsMatch(password, "[0-9]");

            return hasUppercase && hasLowercase && hasNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length -1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
           return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] -nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50]; 
            int count = 0;

            for (int i = 1; i < 100; i += 2)
            {
                odds[count] = i;
                count++;
            }

            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}

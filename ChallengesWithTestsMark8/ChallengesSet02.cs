using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null) 
            {
                return 0;
            }
            double max = double.MinValue; double min = double.MaxValue;
            foreach (double number in numbers) 
            { 
                if (number > max)
                {
                    max = number;
                }
                if (number < min) 
                {
                    min = number;
                }
            }
            return max + min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length) 
            {
                return str2.Length;
            }
            else 
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null) 
            {
                return 0;
            }
            int answer = 0;
            for(int i = 0; i< numbers.Length; i++) 
            {
                answer += numbers[i];
            }
            return answer;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int item = 0;
            foreach (int number in numbers)
            {
               if (number % 2 == 0) 
                { 
                   item += number;
                }
            }
            return item;
        }

        public bool IsSumOdd(List<int> numbers)
        {
           if (numbers == null) 
            {
                return false;
            }
           int sum = 0;
            foreach (int number in numbers) 
            {
                sum += number;
            }
            return(sum % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number < 0 ? 0 : number / 2;
        }
    }
}

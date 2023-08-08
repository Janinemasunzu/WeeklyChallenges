using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool contains = false;
            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase == true)
            {
                word = word.ToLower();
                List<string> lc = words.Select(x => x.ToLower()).ToList();
                contains = lc.Contains(word);
            }
            if (ignoreCase == false)
            {
                contains = words.Contains(word);
            }
            return contains;
        }

        public bool IsPrimeNumber(int num)
        {
            var IsPrime = false;
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    IsPrime = true;
                }
            }

            if ((num == 2) || (num == 3))
            {
                IsPrime = true;
            }
            if (num == 1)
            {
                IsPrime = false;
            }
            return IsPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool item;
            for (int i = 0; i < str.Length; i++)
            {
                item = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        item = false;
                    }
                }
                if (item == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                int firstCtcount = 1;
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    firstCtcount++;
                }
                if (firstCtcount > count)
                {
                    count = firstCtcount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();
            if(elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }
            for(var i = n - 1; i < elements.Count; i+= n)
            {
                nthElement.Add(elements[i]);
            }
            return nthElement.ToArray();
        }
        
            
    } 
}

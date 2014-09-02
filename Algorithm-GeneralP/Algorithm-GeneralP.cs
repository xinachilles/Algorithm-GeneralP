using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm_GeneralP
{
    public class GeneralP
    {
        #region Valid Palindrome
        /*
        
          
         Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
        For example,
        "A man, a plan, a canal: Panama" is a palindrome.
        "race a car" is not a palindrome.
         Note:
    
        * Have you consider that the string might be empty? This is a good question to ask during an interview.
    For the purpose of this problem, we define empty string as valid palindrome.
         */

        /*
            thougt: 1. remove all char not equal to letter 
         *  Note:   2. when the character is not alphanumeric, we need remove that character and move the end point forward by 1     
         * 
         
         */
        public bool IsPalindrome(string s)
        {

            if (s == null || s.Length <= 1)
            {
                return true;
            }
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (s[start].ToString() == " " )
                {
                    start++;
                }
                if (s[end].ToString() == " ")
                {
                    end--;
                }

                if ( String.Compare(s[start].ToString(),s[end].ToString(),true) !=0)
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    
        #endregion

        #region Longest Consecutive
        /*
        Given an unsorted array of integers, find the length of the longest consecutive elements sequence.

        For example,
        Given [100, 4, 200, 1, 3, 2],
        The longest consecutive elements sequence is [1, 2, 3, 4]. Return its length: 4.

        Your algorithm should run in O(n) complexity.
 */

        public int LongestConsecutive(int[] num)
        {
            HashSet<int> result = new HashSet<int>();
            int max = int.MinValue;
            foreach (int item in num)
            {
                result.Add(item);
            }

            foreach (int item in num)
            {
                int count = 1;
                int left = item - 1;
                int right = item + 1;

                while (result.Contains(left))
                {
                    result.Remove(left);
                    left--;
                    count++;

                }

                while (result.Contains(right))
                {
                    result.Remove(right);
                    count++;
                    right++;
                }
                max = Math.Max(count, max);
            }

            return max;
        }
        #endregion


        #region Gas Station

        public int CanCompleteCircuite(List<int> Gas, List<int> Costs)
        {
            int sum = 0; // how many gas left when trave to the current gas station 
            int count = 0; // used to count how many 
            int j = 0;
            for (int i = 0; i < Gas.Count - 1; i++)
            {
                j = i + 1;
                count = 0;
                while (count < Gas.Count + 1)
                {
                    count = count + 1;

                    int current = j >= Costs.Count ? Costs.Count - j : j;


                    sum = (Gas[current] - Costs[current]) + sum;

                    if (sum < 0)
                    {
                        break;
                    }


                }

                if (sum >= 0)
                {
                    return i;
                }

            }


            return -1;
        }
        #endregion

        #region Valid Palindrome
        /*
         Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

        For example,
        "A man, a plan, a canal: Panama" is a palindrome.
        "race a car" is not a palindrome.

        Note:
        Have you consider that the string might be empty? This is a good question to ask during an interview.

        For the purpose of this problem, we define empty string as valid palindrome.
         */
  
        #endregion

        #region  Interleaving String
        //        Given s1, s2, s3, find whether s3 is formed by the interleaving of s1 and s2.
        //For example,
        //Given:
        //s1 = "aabcc",
        //s2 = "dbbca",
        //When s3 = "aadbbcbcac", return true.
        //When s3 = "aadbbbaccc", return false.
        /*solution 1, not corret */
        public bool IsInterleave(string s1, string s2, string s3)
        {
           
            string temp = s3;

            foreach (char c in s1)
            {
                if (temp.Contains(c))
                {

                    temp = temp.Remove(temp.IndexOf(c), 1);
                    }

            }
            if (temp != s2)
            {
                return false;
            }

            temp = s3; 

            foreach (char c in s2)
            {
                if (temp.Contains(c))
                {
                    temp = temp.Remove(temp.IndexOf(c), 1);
                }
            }
            if (temp != s1)
            {
                return false;
            }

            return true;
        
        }
        #endregion

    }
}

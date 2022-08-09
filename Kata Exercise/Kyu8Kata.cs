using System;
using System.Collections.Generic;
using System.Text;

namespace Kata_Exercise
{
    class Kyu8Kata
    {
        /*
        ------------DO YOU SPEAK "ENGLISH"?---------------
        Given a string of arbitrary length with any ascii characters.
         Write a function to determine whether the string contains the whole word "English".
        The order of characters is important -- a string "abcEnglishdef" is correct but "abcnEglishsef" is not correct.
        Upper or lower case letter does not matter -- "eNglisH" is also correct.
        Return value as boolean values, true for the string to contains "English", false for it does not.
        
        public static bool SpeakEnglish(string sentence)
        {
            bool result = sentence.IndexOf("EnGlish", StringComparison.OrdinalIgnoreCase) >= 0;
            return result;
            // return sentence.Contains("english", System.StringComparison.CurrentCultureIgnoreCase); <==alternative solution

        }





        
         -----------------DRAW STAIRS---------------
        Given a number n, draw stairs using the letter "I", n tall and n wide, with the tallest in the top left.
        For example n = 3 result in:
        "I\n I\n  I"
        or printed:
        I
         I
          I
        Another example, a 7-step stairs should be drawn like this:
        I
         I
          I
           I
            I
             I
              I
        
        public static string DrawStairs(int n)
        {
            var result = "I";
            for (int i = 1; i < n; i++)
            {
                result += "\n" + new string(' ', i) + "I";
            }
            return result;
        }

        





        ---------------CHECK SAME CASE---------------
        Write a function that will check if two given characters are the same case.
        If either of the characters is not a letter, return -1
        If both characters are the same case, return 1
        If both characters are letters, but not the same case, return 0
        Examples:
        'a' and 'g' returns 1

        'A' and 'C' returns 1

        'b' and 'G' returns 0

        'B' and 'g' returns 0

        '0' and '?' returns -1
        public static int SameCase(char a, char b)
        {
            if(!Char.IsLetter(a)||!Char.IsLetter(b)) //If either of the characters is not a letter, return -1
            {
                return -1;
            }
            else if(Char.IsUpper(a)==Char.IsUpper(b))//If both characters are the same case, return 1
            {
                return 1;
            }
            else if(Char.IsLetter(a)==true&&Char.IsLetter(b)==true && Char.IsUpper(a) != Char.IsUpper(b))// If both characters are letters, but not the same case, return 0
            {
                return 0;
            }
            else
            {
                return 420;
            }

        }






        ------FIND THE SMALLEST INTEGER IN THE ARRAY----
        Given an array of integers your solution should find the smallest integer.
        For example:
        Given [34, 15, 88, 2] your solution will return 2
        Given [34, -345, -1, 100] your solution will return -345
        */
        public static int FindSmallestInt(int[] args)
        {
            int smallestValue = args[0];

            for (int i=1; i<args.Length;i++)
            {
                if(args[i-1]<args[i]&&args[i-1]<smallestValue)
                {
                    smallestValue = args[i-1];
                }
                else if(args[i]<args[i-1]&& args[i]<smallestValue)
                {
                    smallestValue = args[i];
                }
            }
            return smallestValue;
        }










    }
}

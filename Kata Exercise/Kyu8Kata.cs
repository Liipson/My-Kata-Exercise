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

        */
        







    }
}

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




        --------IS HE GONNA SURVIVE--------

        A hero is on his way to the castle to complete his mission.
        However, he's been told that the castle is surrounded with a couple of powerful dragons!
        each dragon takes 2 bullets to be defeated, our hero has no idea how many bullets he should carry.. 
        Assuming he's gonna grab a specific given number of bullets
        and move forward to fight another specific given number of dragons, will he survive?
        Return True if yes, False otherwise :)

        public static bool Hero(int bullets, int dragons)
        {
            int dragonsHp = dragons * 2;

            if((bullets/dragonsHp)>=1&&dragonsHp!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }





        --------------KEEP HYDRATED!------------------
        Nathan loves cycling.
        Because Nathan knows it is important to stay hydrated, he drinks 0.5 litres of water per hour of cycling.
        You get given the time in hours and you need to return the number of litres Nathan will drink, rounded to the smallest value.
        For example:
        time = 3 ----> litres = 1
        time = 6.7---> litres = 3
        time = 11.8--> litres = 5

        public static int Litres(double time)
        {
            double rounded = Math.Floor(time * 0.5);
            int res = Convert.ToInt32(rounded);
            return res;
        }



        -------BEGINNER - LOST WITHOUT A MAP--------
        Given an array of integers, return a new array with each value doubled.
        For example:
        [1, 2, 3] --> [2, 4, 6]

        public static int[] Maps(int[] x)
        {
            int[] ar = new int[x.Length];

            for(int i=0;i<x.Length;i++)
            {
                ar[i] = x[i]*2;
                Console.WriteLine(ar[i]);
            }

            return ar;

        }



        ------SWITCH IT UP------
        When provided with a number between 0-9, return it in words.
        Example Input :: 1
        Example Output :: "One".
        public static string SwitchItUp(int number)
        {
            switch (number)
            {
                case (0):
                    return "Zero";
                    break;

                case (1):
                    return "One";
                    break;

                case (2):
                    return "Two";
                    break;

                case (3):
                    return "Three";
                    break;

                case (4):
                    return "Four";
                    break;

                case (5):
                    return "Five";
                    break;

                case (6):
                    return "Six";
                    break;

                case (7):
                    return "Seven";
                    break;

                case (8):
                    return "Eight";
                    break;

                case (9):
                    return "Nine";
                    break;
            }
            return "";
        }


        ===========SCHOOL PAPERWORK==========
        Your classmates asked you to copy some paperwork for them.
        You know that there are 'n' classmates and the paperwork has 'm' pages.
        Your task is to calculate how many blank pages do you need. If n < 0 or m < 0 return 0.

        Example:
        n= 5, m=5: 25
        n=-5, m=5:  0
     
        public static int Paperwork(int n, int m)
        {
            if(n<0||m<0)
            {
                return 0;
            }
            else
            {
                return n * m;
            }

        }

  */






    }
}

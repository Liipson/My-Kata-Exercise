using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kata_Exercise
{
    class Kyu7Kata
    {
        /*
            Trolls are attacking your comment section!
            A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
            Your task is to write a function that takes a string and return a new string with all vowels removed.
            For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
            Note: for this kata y isn't considered a vowel.

        public static string Disemvowel(string str)
        {
            List<char> charsToRemove = new List<char>() {'a','A','e','E','i','I','o','O','u','U'};

            foreach(char c in charsToRemove)
            {
                str = str.Replace(c.ToString(), String.Empty);
            }

            return str;
        }


        --------REGEX VALIDATE PIN CODE---------
        ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
        If the function is passed a valid PIN string, return true, else return false.
        Examples (Input --> Output)
        "1234"   -->  true
        "12345"  -->  false
        "a234"   -->  false

        public static bool ValidatePin(string pin)
        {
            Boolean result = true;
            foreach( char c in pin)
            {
                if(char.IsDigit(c)==true)
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }

            if ((pin.Length == 4 || pin.Length == 6) && result == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        ------------------BUILD A SQUARE-----------------------
        I will give you an integer. Give me back a shape that is as long and wide as the integer.
        The integer will be a whole number between 1 and 50.
        Example
        n = 3, so I expect a 3x3 square back just like below as a string:
        +++
        +++
        +++

        public static string GenerateShape(int n)
        {
            string textHolder="";

            for(int i=0;i<n-1;i++)
            {
                for(int j=0;j<n-1;j++)
                {
                    textHolder = textHolder + "+";
                }
                textHolder = textHolder + "+\n";
            }

            for (int k = 0; k < n; k++)
            {
                textHolder = textHolder + "+";
            }


            return textHolder;
        }

        Don't give me five!
        In this kata you get the start number and the end number of a region,
        and should return the count of all numbers except numbers with a 5 in it.
        The start and the end number are both inclusive!
        Examples:
        1,9 -> 1,2,3,4,6,7,8,9 -> Result 8
        4,17 -> 4,6,7,8,9,10,11,12,13,14,16,17 -> Result 12
       
        public static int DontGiveMeFive(int start, int end)
        {
            int count = 0;
            int fiveCounter = 0;
            for (int i = start; i <= end; i++)
            {
                String stringNumber = i.ToString();
                if (stringNumber.Contains("5"))
                {
                    fiveCounter++;
                }
                count++;
            }
            return count - fiveCounter;

        }




        Create a function with two arguments that will return an array of the first n multiples of x.
        Assume both the given number and the number of times to count will be positive numbers greater than 0.
        Return the results as an array or list ( depending on language ).
        Examples
        countBy(1,10)  should return  {1,2,3,4,5,6,7,8,9,10}
        countBy(2,5)  should return {2,4,6,8,10}
         
        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];

            for(int i=0;i<n;i++)
            {
                z[i] = x * (i+1);
                Console.WriteLine(z[i]);
            }

            return z;
        }



        Given an integer n and two other values, build an array of size n filled with these two values alternating.
        Examples
        5, true, false     -->  [true, false, true, false, true]
        10, "blue", "red"  -->  ["blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red"]
        0, "one", "two"    -->  []

        public static object[] Alternate(int n, object firstValue, object secondValue)
        {

            object[] someObjects = new object[n];

            if (n == 0)
            {
                return new object[0];
            }
            else
            {
                for (int i = 0; i< n; i++)
                {
                    if ((i+1) % 2 == 0)
                    {
                       // Console.WriteLine(i + "druga");
                        someObjects[i] = secondValue;
                        //Console.WriteLine(secondValue);
                    }
                    else
                    {
                        //Console.WriteLine(i + "pierwsza");
                        someObjects[i] = firstValue;
                       // Console.WriteLine(firstValue);
                    }
                }
            }

            
            return someObjects;
           // return new object[0];

        }



*/



    }

}

/* This program examines four diffrent methods to reverse a string. 
* The first three methods do not use built-in methods. 
* The last method represents the "normal" way to reverse a string.
* Sources: www.stackoverflow.com/questions/16962322/
* https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#accessing-individual-characters
* Trevor Heehs
*/

using System;

namespace ReverseString
{
        class ReverseStringsThreeWays
    {
                static void Main()
        {
            Console.WriteLine(RevString1("Hello World"));
            Console.WriteLine(RevString2("Hello Solar System"));
            Console.WriteLine(RevString3("Hello Galaxy"));
            Console.WriteLine(RevString4("Hello Universe"));

            // Output:
            // dlroW olleH
            // metsyS raloS olleH
            // yxalaG olleH
            // esrevinU olleH

        }
        // This one is cleanest and easiest to understand in my opinion. 
        // The loop stores characters from beginning of string toward the end 
        // It does this by using = operator instead of +=.
        private static string RevString1(string s)
        {
            string result = string.Empty;
            foreach (char c in s)
            {
                result = c + result;
            }
            return result;
        }
        // Starts from the front of input string. 
        // Here's what the loop is doing:
        // 1. result = H + ""
        // 2. result = e + H
        // 3. result = l + eH...


        // RevString2 starts from the end of string and works toward beginning.
        private static string RevString2(string s)
        {
            string result = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            return result;
        }
        // Here's what the loop is doing.
        // 1. result = "" + H
        // 2. result = H + e
        // 3. result = He + l...

        // RevString3 uses the integer value of index position going forward (i)
        // and subtracts this value from the end of string until we reach the beginning. 
        // It uses array notation to access each string character. Neat trick...
        // The loop iterates forward, but the body of executes backwards.
        private static string RevString3(string s)
        {
            string result = string.Empty;
         
            for (int i = 0; i < s.Length; i++)
            {
                result += s[s.Length - i - 1];
            }
            return result;
        }
        // Here's what the loop is doing.
        // 1. result = "" + H
        // 2. result = H + e
        // 3. result = He + l...

        // RevString4 is the classic method using built in methods. 
        private static string RevString4(string s)
        {
            // Convert input string to char array.
            char[] arr = s.ToCharArray();
            // Reverse Array
            Array.Reverse(arr);
            // Return as new string or print using ToString method.
            return new string(arr);
        }
    }
}
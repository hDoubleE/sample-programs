/* This program uses three methods to reverse a string. 
* The RevString1 and RevString2 methods do not use built-in methods. 
* RevString3 represents is the "normal" way to reverse a string.
* Source: www.stackoverflow.com/questions/16962322/
*/ Trevor Heehs


using System;

namespace ReverseString
{
        class ReverseStringsThreeWays
    {
        static void Main()
        {
            Console.WriteLine(RevString1("Hello World"));
            Console.WriteLine(RevString2("Hello Galaxy"));
            Console.WriteLine(RevString3("Hello Universe"));

            string s5 = "Printing backwards";
            // Starts from back and works to front printing out as it goes.
            //Could place in method and store output to variable.
            for (int i = 0; i < s5.Length; i++)
            {
                System.Console.Write(s5[s5.Length - i - 1]);
            }
            // Output: "sdrawkcab gnitnirP"
        }
        // This is my favorite, cleanest
        static string RevString1(string inputString)
        {
            string result = string.Empty;
            foreach (char c in inputString)
            {
                result = c + result;
            }
            return result;
        }

        static string RevString2(string s)
        {
            string result = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            return result ;
        }

        static string RevString3(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
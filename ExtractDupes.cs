/* This program prints duplicate characters from an input string.
 * Many examples remove duplicate characters and print string with dupes removed. 
 * My goal was to store duplicates and print only the dupes.
 * Source: https://www.csharpstar.com/csharp-program-print-first-non-repeated-character-from-string/
 * 
 * Trevor Heehs
 */

using System;
	
namespace Dupes
{
    public class Program
    {
        public static void Main()
	{
            string extract1 = ExtractDupes("Google");
            Console.WriteLine(extract1);
	}
        public static string ExtractDupes(string input)
	{
	    string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if ((input[i] == input[j]) && i != j)
                    {
                        result += input[j];
                        break;
                    }
                }
            }
            return result;
        }
    }
}
/* This program prints duplicate characters from an input string.
 * Many examples remove duplicate characters or detect them. My goal was to store duplicates and print them.
 * Modified code from source: https://www.csharpstar.com/csharp-program-print-first-non-repeated-character-from-string/
 * Complexity is O(n^2)
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
	        bool isDuplicate;
			string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if ((input[i] == input[j]) && i != j)
                    {
						result += input[i];
                        break;
                    }
                }
			}
			return result;
		}
	}
}
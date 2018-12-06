/* This simple program is going to examine different built in methods for 
 * searching and manipulating strings in C#.
 * To search strings I'll use string array notation[], Contains, StartsWith and EndsWith.
 * To manipulate strings I'll use Substring, Insert and Remove, PadLeft and PadRight, 
 * TrimStart, TrimEnd, and Trim. 
 * No source, going to the Docs for each method. 
 * Trevor Heehs
 */

using System;

namespace StringPlayground
{
    class Program
    {
        static void Main()
        {
            // Let's start by declaring some strings to play with.
            string s1 = "My dear Aunt Sally";
            string s2 = "It was a dark and stormy night";
            string s3 = "Lorem Ipsum is cool";
            string s4 = "I guess I need to know this stuff";

            // </Array Notation>
            // You can use array notation with an index value to acquire
            // read-only access to individual characters in a string.
            
            // String literal as param
            Console.Write("Boss"[0]);
            Console.WriteLine("Boss"[3]);         // Bo
			
            // String variable as param
            Console.WriteLine(s1[4]);             // e

			// Store specified char in string to variable.
            char yInS1 = s1[1];            
            Console.WriteLine(yInS1);             // y

            // Specify char using String.Length.
			Console.WriteLine(s2[s2.Length - 4]); // i
			Console.WriteLine(s2[s2.Length - 1]); // t
            // <Array Notation/>

            // </String.Contains Method>
            // Returns a boolean value indicating whether 
            // a specified substring occurs within a string.
            
            // String literal as param, store result in boolean variable.
            bool wordInS4 = s4.Contains("know");
            Console.WriteLine(wordInS4);           // True

            // String variable as param 
            string word = "Lorem";
            Console.WriteLine(s4.Contains(word)); // False
            // <String.Contains Method/>

            // </StartsWith and EndsWith>
            // Determines whether the beginning of a
            // string instance matches a specified string.
            // Returns a boolean if string parameter matches 
            // string being searched. 
            
            // String literals as params to search for.
            // Case sensitive.
            Console.WriteLine(s2.StartsWith("It"));    // True
            Console.WriteLine(s2.StartsWith("it"));    // False
            Console.WriteLine(s2.EndssWith("night.")); // True
            Console.WriteLine(s2.EndssWith("Night.")); // False
            // <StartsWith and EndsWith/>

            // </IndexOf and LastIndexOf>
            // Returns the index position as int of the first occurrence 
            // of a character or string within instance. 
            // The method returns -1 if character or string is not found.
            
            // Accepts word(string literal) or individual char as param.
            Console.WriteLine(s2.IndexOf("It"));    // 0
            Console.WriteLine(s2.IndexOf("y"));     // 23

            // If param is a word, returns first char index.
            Console.WriteLine(s2.IndexOf("dark"));  // 9
            
            // Find first and last instance of char in string instance.
            Console.WriteLine(s2.IndexOf("a"));     // 4
            Console.WriteLine(s2.LastIndexOf("a")); // 14

            // Return -1 if char is not found.
            Console.WriteLine(s2.IndexOf("b"));     // -1
            // <IndexOf and LastIndexOf/>

            // </Compare and IndexOf>
            // Let's combine the Contains and IndexOf Methods in a quick program. 
            Console.WriteLine("Contains and IndexOf Methods Combined");
            
            string searchFor = "Aunt";
            bool b = s1.Contains(searchFor);
            Console.WriteLine($"{searchFor} is in the string {s1}: {b}");
           
            if (b) {
                int index = s1.IndexOf(searchFor);
                if (index >= 0) {
                Console.WriteLine($"{searchFor} begins at character position {index + 1}");       
                }
            }
            // <Compare and IndexOf/>

            // </Substring>
            // Retrieves a substring.
            // Starts at a specified character position and continues to the end of the string.
            // Can also define ending index.

            // Use IndexOf to declare a couple of placeholders
            int d = s2.IndexOf("d");
            int aunt = s1.IndexOf("r");
            // Use Substrings to assemble a custom string from three source string.
            Console.Write(s1.Substring(0, 3));
            Console.Write(s2.Substring(d, 15));
            Console.Write(s1.Substring(aunt + 1));
            Console.WriteLine(s3.Substring(11));
            // Output: "My dark and stormy Aunt Sally is cool"

            //<Substring/>

            //</Insert and Remove>
            // Returns a new string in which a specified string 
            // is inserted at a specified index position in this instance.

            Console.WriteLine(s1.Insert(7, "old and crazy "));
            // Output: My dear old crazy Aunt Sally.

            Console.WriteLine(s4.Insert(28, s2.Substring(9) + " "));
            // Output: "I guess I need to know this dark and stormy night stuff"

            Console.WriteLine(s1.Remove(2, 5));
            //Output: "My Aunt Sally"

            Console.WriteLine(s4.Remove(23).Insert(22, "...about strings!"));
            // I guess I need to know...about strings!

            //<Insert and Remove/>

            //</PadLeft and PadRight>
            // Returns a new string in which the beginning of the current string
            // is padded with white space or a specified Unicode character.

            // First param takes an int that is length of string plus additional 
            // white spaces. Here I use String.Length. 
            Console.WriteLine(s2.PadLeft(s2.Length + 15));
            // Output: "               It was a dark and stormy night"

            // Second param takes a char and inserts it into extra space.
            Console.WriteLine(s1.PadLeft(s2.Length + 5, '.'));
            // Output: ".....My dear Aunt Sally"
            
            // PadRight computes the same at the end of string.
            Console.WriteLine(s2.PadRight(s2.Length + 15, '!'));
            // "It was a dark and stormy night!!!!!!!!!!!!!!!"
            
            // Place char in variable and pass as param. 
            char pad = '.';
            Console.WriteLine(s1.PadRight(s1.Length + 5, pad));
            // "Output: My dear Aunt Sally....."
            //<PadLeft and PadRight/>

            //</Trim Methods>

            string s5 = "     Here's a string needs trimming     ";

            // Trims all leading and trailing whitespace from string. 
            Console.WriteLine(s5.Trim());
            // Output: "Here's a string needs trimming" 

            Console.WriteLine(s5.TrimStart());
            //Output: "Here's a string needs trimming     "

            Console.WriteLine(s5.TrimEnd());
            //Output: "     Here's a string needs trimming"

            // Optionally accepts a char[] array as param
            // with specified chars to trim.

            string s6 = "*$*$*$ Hello *$*$*$";
            char[] charsToTrim = {'$', '*', ' '};
            Console.WriteLine(s6.Trim(charsToTrim));
            // Output: "Hello"
            
            Console.WriteLine(s6.TrimStart(charsToTrim));
            // Output: "Hello *$*$*$"

            Console.WriteLine(s6.TrimEnd(charsToTrim));
            // Output: "*$*$*$ Hello"





        }
    }
}
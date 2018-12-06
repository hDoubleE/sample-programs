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
            string s1 = "My dear aunt Sally";
            string s2 = "It was a dark and stormy night";
            string s3 = "Lorem Ipsum is cool";
            string s4 = "I guess I need to know this stuff";

            
            // </Array Notation>
            // You can use array notation with an index value to acquire
            // read-only access to individual characters in a string.
            Console.WriteLine("Array Notation");
            Console.Write("Cool"[0]);
            Console.WriteLine("Cool"[3]);         // Cl
			Console.WriteLine(s1[4]);             // e
			char yInS1 = s1[1];            
            Console.WriteLine(yInS1);             // y
			Console.WriteLine(s2[s2.Length - 4]); // i
			Console.WriteLine(s2[s2.Length - 1]); // t
            Console.WriteLine();
            // <Array Notation/>

            // </String.Contains Method>
            // Returns a boolean value indicating whether 
            // a specified substring occurs within a string.
            Console.WriteLine("Contains Method");
            string s5 = "know";
            bool s5inS4 = s4.Contains(s5);
            Console.WriteLine(s5inS4);              // True
            Console.WriteLine(s2.Contains("cool")); // False
            System.Console.WriteLine();
            // <String.Contains Method/>

            //</StartsEndsWith>
            // Determines whether the beginning of
            // string instance matches a specified string.
            // Returns a boolean if string parameter matches 
            // string being searched. 
            Console.WriteLine("StartsWith and EndsWith Method");
            Console.WriteLine(s2.StartsWith("It"));    // True
            Console.WriteLine(s2.StartsWith("it"));    // False
            Console.WriteLine(s2.EndssWith("night.")); // True
            Console.WriteLine(s2.EndssWith("Night.")); // False
            //<StartsEndsWith/>

            // </IndexOf LastIndexOf>
            // Reports the index of the first occurrence of a character or string within instance. 
            // The method returns -1 if character or string is not found.
            Console.WriteLine("IndexOf and LastIndexOf Method");
            Console.WriteLine(s2.IndexOf("I"));     // 0
            Console.WriteLine(s2.IndexOf("y"));     // 23
            Console.WriteLine(s2.LastIndexOf("i")); // 26
            Console.WriteLine(s2.IndexOf("a"));     // 4
            Console.WriteLine(s2.LastIndexOf("a")); // 14
            Console.WriteLine(s2.IndexOf("b"));     // -1
            Console.WriteLine(s2.IndexOf("c"));     // -1
            // <IndexOf LastIndexOf/>

            // </Compare and IndexOf>
            // Let's combine the Contains and IndexOf Methods in a quick program. 
            Console.WriteLine("Contains and IndexOf Methods Combined");
            
            string searchFor = "aunt";
            bool b = s1.Contains(searchFor);
            Console.WriteLine($"{searchFor} is in the string {s1}: {b}");
           
            if (b) {
                int index = s1.IndexOf(searchFor);
                if (index >= 0) {
                Console.WriteLine($"{searchFor} begins at character position {index + 1}");       
                }
            }
            // <Compare and IndexOf/>

            
        }
    }
}
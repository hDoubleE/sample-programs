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
            Console.Write("Cool"[0]);
            Console.WriteLine("Cool"[3]);         // Cl
			Console.WriteLine(s1[4]);             // e
			char yInS1 = s1[1];            
            Console.WriteLine(yInS1);             // y
			Console.WriteLine(s2[s2.Length - 4]); // i
			Console.WriteLine(s2[s2.Length - 1]); // t
            // <Array Notation/>

            // </String.Contains Method>
            // Returns a boolean value indicating whether 
            // a specified substring occurs within a string.
            string s5 = "know";
            bool s5inS4 = s4.Contains(s5);
            Console.WriteLine(s5inS4);              // True
            Console.WriteLine(s2.Contains("cool")); // False

            // <String.Contains Method/>



        }
    }
}
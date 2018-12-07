/* 

Simple coding problem from Eloquent Javascript, 3rd Edition by Marijn Haverbeke. 
Solution not provided. Adapted to C# by Trevor Heehs.
"Write a loop that makes seven calls to console.log to output the following triangle..."
            
#
##
###
####
#####
######
#######
              
*/
using System;

namespace Pyramid
{
    public class Program
    {
        public static void Main()
        {
            const int MAX_LENGTH = 7;
            string triangle = "";
            // Outer loop prints lines.
            for (int i = 0; i <= MAX_LENGTH; i++)
            {
                // Inner loop prints characters limited by outer loop iteration number.
                while (triangle.Length < i)
                {
                    triangle += "#";
                    Console.WriteLine(triangle);
                }
            }
        }
    }
}

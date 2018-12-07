/* Another one from Harold's CS 101 class. Looking at compounding interest. 
 * I thought...a computer can do this better, turns out it can. 
 * No source code. I wrote it from scratch and it works.
 * Trevor Heehs
 */

using System;

namespace InterestCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Method call with initial investment amount, years invested, and interest.
            CalculateInterest(100, 30, 5);
        }

        // Had to input whole numbers as decimal to meet Harold's precise requirements.
        private static void CalculateInterest(decimal amount, int years, decimal interest)
        {
            // Interest to percentage.
            interest = interest / 100;
            
            // Loop through each year.
            for (int i = 0; i < years; i++)
            {
                // Calculate annual interest per each iteration.
                decimal interestPerYear = amount * interest;

                // Add annual interest to amount each iteration and add to net amount.
                // Store in result variable.
                decimal result = amount += interestPerYear;

                // Print result to the nearest penny, thanks StackOverflow!
                // Use Math.Round with some overloads for this.
                // Print compounded amount on each "annual" iteration of loop.
                Console.WriteLine(Math.Round(result, 2, MidpointRounding.AwayFromZero));
            }
        }
    }
}
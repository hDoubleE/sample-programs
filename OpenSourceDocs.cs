/* This is my first open source contribution.
 * The published code can be found at: 
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#format-strings 
 * Written with help from the open source community by: Trevor Heehs
 * Simple program showing two ways to print format strings. 
 * One using old String.Format method, the other using string interpolation.
 * Also showcases new Value.Tuple feature.
*/

using System;

 namespace StringCompare
{
    class Program
    {
        static void Main()
        {
            // Used Named Value.Tuple (new in C# 7.1) for variable declaration.
            // Print using String interpolation.
            var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
            Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
            Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
            Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");

            // Output:
            // Jupiter Hammon was an African American poet born in 1711.
            // He was first published in 1761 at the age of 50.
            // He'd be over 300 years old today. 
            // </SnippetStringInterpolation>

            System.Console.WriteLine();

            // Print using `Format.String` method.
            var pw = (firstName: "Phillis", lastName: "Wheatley", born: 1753, published: 1773);
            Console.WriteLine("{0} {1} was an African American poet born in {2}.", pw.firstName, pw.lastName, pw.born);
            Console.WriteLine("She was first published in {0} at the age of {1}.", pw.published, pw.published - pw.born);
            Console.WriteLine("She'd be over {0} years old today.", Math.Round((2018d - pw.born) / 100d) * 100d);

            // Output:
            // Phillis Wheatley was an African American poet born in 1753.
            // She was first published in 1773 at the age of 20.
            // She'd be over 300 years old today.
            // </SnippetStringFormat>
        }
    }
}

// Here’s the associated content written in markdown published with the code snippets.
/*  

A format string is a string whose contents are determined dynamically at runtime. 
Format strings are created by embedding *interpolated expressions* or placeholders inside of braces within a string. 
Everything inside the braces (`{...}`) will be resolved to a value and output as a formatted string at runtime. 
There are two methods to create format strings: string interpolation and composite formatting.

 ### String Interpolation
Available in C# 6.0 and later, [*interpolated strings*](../../language-reference/tokens/interpolated.md) are identified 
by the `$` special character and include interpolated expressions in braces. If you are new to string interpolation, 
see the [String interpolation - C# interactive tutorial](../../tutorials/intro-to-csharp/interpolated-strings.yml) for 
a quick overview.

 Use string interpolation to improve the readability and maintainability of your code. 
 String interpolation achieves the same results as the `String.Format` method, but improves ease of use and inline clarity.
 [!code-csharp[csProgGuideFormatStrings](~/samples/snippets/csharp/programming-guide/strings/Strings_1.cs#StringInterpolation)]

 ### Composite Formatting
The <xref:System.String.Format%2A?displayProperty=nameWithType> utilizes placeholders in braces to create a format string. 
This example results in similar output to the string interpolation method used above.
  
[!code-csharp[csProgGuideFormatStrings](~/samples/snippets/csharp/programming-guide/strings/Strings_1.cs#StringFormat)]
 For more information on formatting .NET types see [Formatting Types in .NET](../../../standard/base-types/formatting-types.md).
*/
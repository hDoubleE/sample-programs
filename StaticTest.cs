/* Simple program that highlights instance vs static members.
 * Source C# 7.0 Pocket Reference, Albahari & Albahari, p.15
 * Added public Properties and made Fields private. 
 * Trevor Heehs
*/
using System;

namespace StaticTest
{
    class Program
    {
        private static void Main()
        {
            //Instantiate 2 new Pandas.
            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");

            // Print Panda Names...Instance!
            // Call from Object.
            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);

            // Print Panda population...static!
            // Call from Type.
            Console.WriteLine(Panda.Population);
        }
    }
    public class Panda
    {
        // Public fields.
        public string Name;
        public static int Population;

        // Constructor: sets field values.
        public Panda(string n)
        {
            //Assign Name string argument passed during instantiation.
            Name = n;
            // Increase Population by one for each new Panda object.
            Population = ++Population;

        }
    }
}

// Output:
// Pan Dee
// Pan Dah
// 2
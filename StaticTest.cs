/* Simple program that highlights instance vs static members.
 * Source C# 7.0 Pocket Reference, Albahari & Albahari, p.15
 * Added public Properties and made Fields private. 
*/ Trevor Heehs

using System;

namespace StaticTest
{
    class Program
    {
        private static void Main()
        {
            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");

            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);

            Console.WriteLine(Panda.Population);
        }
    }
    public class Panda
    {
        private string name;
        private static int population;

        public string Name { get; set; }
        public static int Population { get; set; }

        public Panda(string n)
        {
            Name = n;
            Population = Population + 1;
        }
    }
}
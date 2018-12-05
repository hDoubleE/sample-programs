/* This program examines the difference between value types and reference types. 
 * The fundamental difference between these types is how they are handled in memory.
 * The assignment of a value type always copies the instance/value.
 * The assignment of a reference type, copies the reference to an object.
 * Source code: C# 7.0 Pocket Reference, Albahari and Albahari, p 17-19
 * Trevor Heehs
 */

using System;

namespace ValueRefTypes
{
    public class Program
    {
        static void Main()
        {
            // p1 initialized to default value: 0.
            ValPoint p1 = new ValPoint();
            
            Console.WriteLine(p1.X);  // 0
            Console.WriteLine(p1.Y);  // 0

            //    Point Struct
            //     +-------+
            //     |   X   |
            //     +.......+
            //     |   Y   |
            //     +-------+

            p1.X = 4;
            p1.Y = 4;
			
            // Assignment causes values of p1 to copy to p2.
            ValPoint p2 = p1;  

            //        P1          P2
            //     +-------+   +-------+
            //     |   4   |   |   4   |
            //     +.......+   +.......+
            //     |   4   |   |   4   |
            //     +-------+   +-------+

            Console.WriteLine(p1.X);  // 4
            Console.WriteLine(p1.Y);  // 4
            Console.WriteLine(p2.Y);  // 4
            Console.WriteLine(p2.X);  // 4

            p1.X = 7;
            p1.Y = 7;  // Change p1 values.

            //        P1          P2
            //     +-------+   +-------+
            //     |   7   |   |   4   |
            //     +.......+   +.......+
            //     |   7   |   |   4   |
            //     +-------+   +-------+
            
            // Changes p1 value.
            Console.WriteLine(p1.X);  // 7
            Console.WriteLine(p1.Y);  // 7
            Console.WriteLine(p2.Y);  // 4
            Console.WriteLine(p2.X);  // 4

            RefPoint p3 = new RefPoint();

            //  p3 Reference ---> Object
            //                   +-------+
            //                   |   X   |
            //                   +.......+
            //                   |   Y   |
            //                   +-------+

            p3.X = 2;
            p3.Y = 2;

            Console.WriteLine(p3.X);  // 2
            Console.WriteLine(p3.Y);  // 2

            RefPoint p4 = p3;
            
            //  p3 Reference ---> Object <--- p4 Reference
            //                   +-------+
            //                   |   2   |
            //                   +.......+
            //                   |   2   |
            //                   +-------+
            
            Console.WriteLine(p3.X);  // 2
            Console.WriteLine(p3.Y);  // 2
            Console.WriteLine(p4.Y);  // 2
            Console.WriteLine(p4.X);  // 2

            p3.X = 9;
            p3.Y = 9;

            //  p3 Reference ---> Object <--- p4 Reference
            //                   +-------+
            //                   |   9   |
            //                   +.......+
            //                   |   9   |
            //                   +-------+

            Console.WriteLine(p3.X);  // 9
            Console.WriteLine(p3.Y);  // 9
            Console.WriteLine(p4.Y);  // 9
            Console.WriteLine(p4.X);  // 9

            // The moral is: when you change the value of an object 
            // all instances are changed due to being reference types.
            // With value types, this is not the case.

        }
        
    }
    
    public class RefPoint  // Reference type: class.
    {
        public int X;
        public int Y;
    } 

    public struct ValPoint  // Value type: struct.
    {
        public int X;
        public int Y;
    }
}
using Assignment.First_Project;
using Assignment.Second_Project;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region First Project
            #region Test
            //Maths maths1 = new Maths(4,4);
            //int Result1 = maths1.Sum();
            //Maths maths2 = new Maths(4,4);
            //int Result2 = maths2.Subtract();
            //Maths maths3 = new Maths(4,4);
            //int Result3 = maths3.Multiply();
            //Maths maths4 = new Maths(4,4);
            //int Result4 = maths4.Divided();
            //Console.WriteLine($"Sum: {Result1}");
            //Console.WriteLine($"Subtract: {Result2}");
            //Console.WriteLine($"Multiply: {Result3}");
            //Console.WriteLine($"Divided: {Result4}"); 
            #endregion

            // Use Static Keyword
            //Maths maths = new Maths();  // Invalid
            //Maths maths;  // Invalid
            //Console.WriteLine($"Addition: {Maths.Sum(3, 4)}");
            //Console.WriteLine($"Subtract: {Maths.Subtract(6, 2)}");
            //Console.WriteLine($"Multiply: {Maths.Multiply(5, 8)}");
            //Console.WriteLine($"Divided: {Maths.Divided(8, 2)}");
            //Console.WriteLine($"Divided: {Maths.Divided(8, 33)}");
            //Console.WriteLine(Maths.Divided(8, 0)); 
            #endregion

            #region Second Project
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString()); 
            Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());

            //D3 = D1 + D2;
            //Console.WriteLine(D3);
            //D3 = D1 + 7800;
            //Console.WriteLine(D3);
            //D3 = 666 + D3;
            //Console.WriteLine(D3);
            //D1 = D1 - D2;
            //Console.WriteLine(D1);
            //D3 = ++D1;  // In Minutes
            //Console.WriteLine(D3);
            //D3 = --D2;  // In Minutes
            //Console.WriteLine(D3);

            //if (D1 > D2)
            //    Console.WriteLine($"Duration1 is bigger!");
            //else
            //    Console.WriteLine($"Duration2 is bigger!");

            //if (D1 <= D2)
            //    Console.WriteLine($"Duration2 is greater than or equal Duration1!");
            //else
            //    Console.WriteLine($"Duration1 is bigger!");

            DateTime obj = (DateTime)D1;  // Valid
            Console.WriteLine(obj);
            #endregion
        }
    }
}
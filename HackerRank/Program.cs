using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            // Declare second integer, double, and String variables.
            // Read and save an integer, double, and String to your variables.
            var j = Convert.ToInt32(Console.ReadLine());
            var e = Convert.ToDouble(Console.ReadLine());
            var p = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + j);
            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:0.0}", d+e);
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + p);

            Console.ReadLine();
        }
    }
}

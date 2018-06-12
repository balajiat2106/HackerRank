using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var temp = Convert.ToInt32(Console.ReadLine());
            int[] a=new int[temp]; int[] b=new int[temp]; int[] c=new int[temp];
            for (int i = 0; i < temp; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < temp; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < temp; i++)
            {
                c[i] = Convert.ToInt32(Console.ReadLine());
            }

            var tempstr = triangleOrNot(a, b, c, temp);
            foreach (string t in tempstr)
            {
                Console.WriteLine(t);
            }
            Console.ReadLine();
        }
        static string[] triangleOrNot(int[] a, int[] b, int[] c, int temp)
        {
            string[] result = new string[temp];
            for (int i = 0; i < temp; i++)
            {
                var nonTriangle = (a[i] + b[i] - c[i]) * (a[i] + c[i] - b[i]) * (b[i] + c[i] - a[i]);
                if (nonTriangle > 0)
                {
                    result[i] = "Yes";
                }
                else
                {
                    result[i] = "No";
                }
            }
            return result;
        }
    }
}

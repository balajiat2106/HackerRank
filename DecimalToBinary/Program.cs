using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> tempList=new List<int>();
            while (n > 0)
            {
                var tempModValue = n%2;
                n = n/2;
                tempList.Add(Convert.ToChar(tempModValue));
            }
            int maxValue=0;
            int previous = -1;
            foreach (int i in tempList)
            {
                if (previous != -1)
                {
                    if (previous==1 && i==1)
                    {
                        maxValue++;
                    }
                }
                previous = i;
            }
            Console.WriteLine(maxValue);
            Console.ReadLine();
        }
    }
}

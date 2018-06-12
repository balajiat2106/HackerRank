using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            var tip = meal_cost*tip_percent/100;
            var tax = meal_cost*tax_percent/100;
            var totalcost = meal_cost + tip + tax;

            Console.WriteLine("The total meal cost is {0} dollars.",Math.Round(totalcost));
            Console.ReadLine();
        }
    }
}

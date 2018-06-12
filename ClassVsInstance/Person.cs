using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsInstance
{
    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            age = initialAge < 0 ? 0 : initialAge;
            // Add some more code to run some checks on initialAge
        }
        public void amIOld()
        {
            if (age == 0) Console.WriteLine("Age is not valid, setting age to 0.");
            if(age<13) Console.WriteLine("You are young.");
            else if(age>=13 && age<18) Console.WriteLine("You are a teenager.");
            else Console.WriteLine("You are old.");
            // Do some computations in here and print out the correct statement to the console 
        }

        public void yearPasses()
        {
            age++;
            // Increment the age of the person in here
        }
        static void Main(string[] args)
        {
            var inputAge = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < inputAge; i++)
            {
                Person p = new Person(Convert.ToInt32(Console.ReadLine()));
                p.amIOld();
                p.yearPasses();
                p.amIOld();
            }
        }
    }
}

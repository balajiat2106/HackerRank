using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Animal
    {
        protected bool isMammal;
        protected bool isCarnivorous;

        public Animal(bool isMammal, bool isCarnivorous)
        {
            this.isMammal = isMammal;
            this.isCarnivorous = isCarnivorous;
        }

        public bool getIsMammal()
        {
            return this.isMammal;
        }

        public bool getIsCarnivorous()
        {
            return this.isCarnivorous;
        }

        abstract public string getGreeting();

        public void printAnimal(string name)
        {
            Console.WriteLine("A {0} says '{1}', is{2} carnivorous, and is{3} a mammal.",
            name,
            this.getGreeting(),
            this.getIsCarnivorous() ? "" : " not",
            this.getIsMammal() ? "" : " not");
        }
    }


    class Dog : Animal
    {
        public Dog():base(true,false)
        {

        }

        public override string getGreeting()
        {
            return "ruff";
        }

    }
    /**
    *   Cow class
    **/
    class Cow : Animal
    {
        public Cow():base(true,false)
        {
            
        }
         public override string getGreeting()
        {
            return "moo";
        }
    }
    /**
    *   Duck class
    **/
    class Duck : Animal
    {
        public Duck():base(true,false)
        {
            
        }
         public override string getGreeting()
        {
            return "quack";
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.printAnimal("dog");

            Animal cow = new Cow();
            cow.printAnimal("cow");

            Animal duck = new Duck();
            duck.printAnimal("duck");
        }
    }
}

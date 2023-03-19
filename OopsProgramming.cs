using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA07ClassWork
{
    #region POLYMORPHISM  
    class Janwar
    {      
        #region OVERLOADING (METHOD OVERLOADING)
        public void Sleep()
        {
            Console.WriteLine("Animal Sleep");
        }

        public void Sleep(string a)
        {
            Console.WriteLine(a + "overload animal sleep");
        }
        #endregion

        #region OVERRIDDING
        class Offspring
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public virtual void Sleep()
            {
                Console.WriteLine("Offspring Sleep zzzZZZ");
            }

            public virtual void Sound()
            {
                Console.WriteLine("Offspring Sound ....");
            }
        }
        class Kitten : Offspring
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public override void Sleep()
            {
                Console.WriteLine("Kitten Sleep zzzZZZ");
            }

            public override void Sound()
            {
                Console.WriteLine("Kitten Sound : Meow Meow");
            }
        }
        class Puppy : Offspring
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public override void Sleep()
            {
                Console.WriteLine("Puppy Sleep zzzZZZ");
            }

            public override void Sound()
            {
                Console.WriteLine("Puppy Sound : Boww Boww");
            }
        }

        #endregion

        #region OVERLOADING (CONSTRUCTOR OVERLOADING)
        public Janwar() 
        /* 
         1. Method(Constructor) name should be same as class name 
         2. It has no return time
         3. Automatically called when we initialize class
        */
        {
            Console.WriteLine("Constructor called");
        }

        public Janwar(string a)
        {
            Console.WriteLine(a + "overload constructor called");
        }
        #endregion
    }

    #endregion

    #region INHERITANCE
    /* Parent Child Relationship */
    class Animal
    {

        public string Name { get; set; }
        public string Color { get; set; }
        public void Sleep()
        {
            Console.WriteLine("Animal Sleep zzzZZZ");
        }

        public void Sound()
        {
            Console.WriteLine("Animal Sound ....");
        }
    }
    class Cat : Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public void Sleep()
        {
            Console.WriteLine("Cat Sleep zzzZZZ");
        }

        public void Sound()
        {
            Console.WriteLine("Cat Sound : Meow Meow");
        }
    }

    class Dog : Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public void Sleep()
        {
            Console.WriteLine("Dog Sleep zzzZZZ");
        }

        public void Sound()
        {
            Console.WriteLine("Dog Sound : Boww Boww");
        }
    }
    #endregion

   
}

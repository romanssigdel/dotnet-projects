using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
    //Multi level iheritace and multiple inheritance
    public class Animal
    {
        public string name = "Animal";
        public void eats()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog:Animal {
    public void barks()
        {
            Console.WriteLine("Barking...");
        }
    }
    public class BabyDog:Dog
    {
        public void crys()
        {
            Console.WriteLine("Crying....");
        }
    }
    public class Cat:Animal
    {
        public void meows()
        {
            Console.WriteLine("Meowing...");
        }
    }
    public class BabyCat: Cat
    {
        public void rollsUp()
        {
            Console.WriteLine("Rolling...");
        }
    }
}

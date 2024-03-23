using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{

    //Method overriding
    public class Animal1
    {
        public virtual void  eats()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog1:Animal1
    {
        public override void eats()
        {
            Console.WriteLine("Dog eating....");
        }
    }

    //Method overloading
    public class Sum
    {
        
        public int add(int a, int b, int c)
        {
            int add = a + b + c;
            return add;
        }
        public int add(int a, int b)
        {
            int add = a + b;
            return add;
        }
    }
}

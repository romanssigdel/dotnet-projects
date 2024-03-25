using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Question no 1.
           Q1 q1 = new Q1();
            q1.testReadline();
            q1.testRead();
            */

            /* Question no 2.
             * Polymorphism
             Q2 q2 = new Q2();
            int a = q2.sum(5, 6);
            Console.WriteLine(a);
            int b = q2.sum(5, 6, 7);
            Console.WriteLine(b);
            */


            //Question no 3.
              //Default, Parameterized, Default Constructor
           Q3 q3 = new Q3();
            Q3 q3i = new Q3("Ram", "Nala");
           Q3 q3j = Q3.showPrivate("hello");
            q3i.show();
            //

            /* Question no 4
             * Operator Overloading
            Q4 t1 = new Q4(1,2);
            Q4 t2 = new Q4(2,3);
            Q4 sum = t1 + t2;
            Console.WriteLine("x: "+ sum.x +"y: "+ sum.y);
            */

            /* Question no 5
             * 
            Multilevel inheritance
            BabyDog babyDog = new BabyDog();
            babyDog.eats();
            babyDog.barks();
            babyDog.crys();
            Console.WriteLine("Grandparent's name is "+ babyDog.name);

            Multiple inheritance
            BabyCat babycat = new BabyCat();
            babycat.eats();
            babycat.meows();
            babycat.rollsUp();
            Console.WriteLine("Grandparent's name is "+babycat.name);
            */

            /*Question no 6
            //Method overriding
            Dog1 dog1 = new Dog1();
            dog1.eats();

            //Method overloading
            Sum sum =  new Sum();
            int s1 = sum.add(1, 2, 3);
            Console.WriteLine(s1);
            int s2 = sum.add(1,2);
            Console.WriteLine(s2);
            */

            /*question no 7
             //Stack memory operation
            Stack stack = new Stack(5);
            stack.push(10);
            stack.push(20);
            stack.push(30);
            stack.push(23);
            stack.push(23);
            stack.pop();
            stack.pop();
            stack.pop();
            stack.peek();
            stack.display();
            */

            //question no 8
            //Q8 q8 = new Q8();
            // if statement
            //q8.primeComposite();
            //switch
            //q8.calculate();
            //conditional statement
            //q8.max();

            //Question no 9
            //Q9 q9 = new Q9();
            //q9.forLoop();
            //q9.whileLoop();
            //q9.doWhileLoop();

            //q.no 10
            //Reverse rev = new Reverse();
            //rev.reverseNumber();
            //rev.reverseString();

            //q.no 11
            //Q11 q11 = new Q11();
            //q11.oneDimensionalArray();

            //Q.no 15
            /*Demo obj = new Demo();
            AddDelegate addDelegate = new AddDelegate(obj.Sum);
            addDelegate(12, 10);

            DiffDelegate diffDelegate = new DiffDelegate(Demo.diff);
            int d = diffDelegate(4, 5);
            Console.WriteLine(d);

            GetNameDelegate getNameDelegate = new GetNameDelegate(obj.getName);
            string name = getNameDelegate("Ram");
            Console.WriteLine(name);*/
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
    public class Q9
    {
        public void forLoop()
        {
            int number = 5;
            int factorial = 1;
            for(int i = 1; i < number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial " + factorial);
        }
        public void whileLoop()
        {
            int number = 5;
            while(number >= 1)
            {
                Console.WriteLine(number);
               number--;
            }
        }
        public void doWhileLoop()
        {
            string password;
            do
            {
                Console.WriteLine("Enter password");
                 password = Console.ReadLine();
            }
            while(password != "secret");
                Console.WriteLine("Granted Access");
        }
    }
}

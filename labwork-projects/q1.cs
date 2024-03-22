using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
    public class Q1
    {
        public void testRead()
        {
            
            // doesn't add newline at the end
            Console.Write("Enter your roll number.");
            int rollNo = Console.Read();
            char roll = (char)rollNo;
            Console.Write("Roll no is "+roll+".");
        }
        public void testReadline()
        {
            // adds newline at the end
            Console.WriteLine();
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("Name is " + name + ".");
        }
    }
}

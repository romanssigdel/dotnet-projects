using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
    public class Q3
    {
        
        public string name;
        public string address;
        private string message;

        //Parameterized Constructor
        public Q3(string name,string adddress) {
            this.name = name;
            this.address = adddress;
        } 

        //Default Constructor
        public Q3 () { }

        //Private Constructor
        private Q3(string message) {
        Console.WriteLine(message);
        }
        public void show()
        { 
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Address is " + address);
        }
        public static Q3 showPrivate(string message)
        {
            return new Q3(message);
        }
    }
}

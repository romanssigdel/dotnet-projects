using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
    public class Q8
    {
        public void primeComposite()
        {
            //if statement
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                count = count + 1;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("composite");
            }
        }
        public void calculate()
        {
            // switch case
            Console.WriteLine("Enter a number.\n 1. add\n 2. substract\n 3. Divide\n 4. Multiply");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    int sum = a + b;
                    Console.WriteLine("Sum: "+ sum);
                    break;

                case 2:
                    int sub = a - b; 
                    Console.WriteLine("Substraction: "+ sub);
                    break;
                case 3:
                    int div = a / b;
                    Console.WriteLine("Divison: " + div);
                    break;
                case 4:
                    int prod = a * b;
                    Console.WriteLine("Product: " + prod);
                    break;
                default: Console.WriteLine("invalid!"); break;
            }
        }
        public void max()
        {
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int max = a > b ? a : b;
            Console.WriteLine(max + " is the greatest");
        }
    }
}

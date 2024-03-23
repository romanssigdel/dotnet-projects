using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
    public class Stack
    {
        public int[] stackArray;
        public int top;
        public int maxsize;

        public Stack(int size)
        {
            maxsize = size;
            stackArray = new int[maxsize];
            top = -1;
        }
        public void push(int value)
        {
            if(top == maxsize-1)
            {
                Console.WriteLine("Stack overflow!");
            }
            else
            {
                stackArray[++top] = value;
                Console.WriteLine($"Pushed top[{top}]: {value} to the stack");
            }
        }
        public void pop()
        {
           if(top == -1)
            {
                Console.WriteLine("Stack is empty!");
            }
            else
            {
                int poppedElement = stackArray[top--];
                Console.WriteLine($"Popped element {poppedElement} from stack.");
            }
        }
        public void peek()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is empty!");
            }
            else
            {
                Console.WriteLine($"Top Element is {stackArray[top]}");
            }
        }
        public void display()
        {
            Console.WriteLine("Elements of the Stack: ");
            if(top == -1)
            {
                Console.WriteLine("Stack is empty!");
            }
            else
            {
                for(int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stackArray[i]);
                }
            }
        }
    }
}

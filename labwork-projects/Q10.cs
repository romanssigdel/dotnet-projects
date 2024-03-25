using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
	public class Reverse
	{
		public void reverseNumber()
		{
			Console.WriteLine("Enter a Multidigit number.");
			int num = Convert.ToInt32(Console.ReadLine());
			int sum = 0;
			while(num != 0) {
				int r = num % 10;
				sum = sum * 10 + r;
				num = num / 10;
			}
			Console.WriteLine($"Reversed Number is {sum}");

		}
		public void reverseString()
		{
			string str = "hello";
			string reverse = "";
			int length = 0;

			length = str.Length -1;

            while (length >= 0)
            {
				reverse = reverse + str[length];
				length--;
            }
			Console.WriteLine($"Reverse of the word {str} is {reverse}");


        }
	}
}

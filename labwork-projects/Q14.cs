using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
	public class Q14
	{
		public void sum()
		{
			Console.WriteLine("Enter a Multidigit Number.");
			int num = Convert.ToInt32(Console.ReadLine());
			int sum = 0;
			while (num > 0)
			{
				sum = sum + num % 10;
				num = num / 10;
			}
			Console.WriteLine(sum);
		}
	}
}

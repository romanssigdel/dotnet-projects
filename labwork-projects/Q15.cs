using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
	public delegate string GetNameDelegate(string name);
	public delegate void AddDelegate(int a, int b);
	public delegate  int DiffDelegate(int a, int b);
	public class Demo
	{
		public void Sum(int a, int b)
		{
			int s = a + b;
			Console.WriteLine($"sum :{s}");
		}
		public static int diff(int a, int b)
		{
			int d = a - b;
			return d;
		}
		public string getName(string name)
		{
			return name;
		}
	}
}

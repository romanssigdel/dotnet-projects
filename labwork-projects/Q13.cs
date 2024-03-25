using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
	public class Q13
	{
		public string name, address;
		public int age;
		public Q13(string name, string address,int age)
		{
			this.name = name;
			this.address = address;
			this.age = age;
		}
		public void profile()
		{
			Console.WriteLine($"Name: {name} \nAddress: {address} \nAge: {age}");
		}
	}
}

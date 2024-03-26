using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
	public class Q17
	{
		public void lambdaExpns()
		{
		List<int> nums = new List<int>() {1,2,3,4,5,6,7,8,9};
		Console.WriteLine("Cube:");
			//Lambda Expression
			var cube = nums.Select(x=> x*x*x);
            foreach (var item in cube)
            {
                Console.Write("{0} ",item);
            }
			Console.WriteLine();

			Console.WriteLine("Even numbers in the list are: ");
			var even = nums.FindAll(x=>(x%2==0));
            foreach (var item in even)
            {
				Console.Write("{0} ", item);
            }
			Console.WriteLine();
		}

	}
	public class Student
	{
		public int id { get; set; }
		public string name { get; set; }

		public void lambdaExpnSort()
		{
			List<Student> details = new List<Student>() {
			new Student{ id = 1, name = "Laxman" },
				new Student{ id = 2, name = "Sita" },
				new Student{ id = 3, name = "Hari" },
				new Student{ id = 4, name = "Krishna" },
				new Student { id = 5, name = "Ram" }
			};
			var newDetails = details.OrderBy(x => x.name);
            foreach (var item in newDetails)
            {
				Console.WriteLine(item.id + " " + item.name);
            }
        }
	}
}

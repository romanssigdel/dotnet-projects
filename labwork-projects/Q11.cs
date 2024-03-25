using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
	public class Q11
	{
		public void oneDimensionalArray()
		{
		Console.WriteLine("Enter the size of an array");
		int i = Convert.ToInt32(Console.ReadLine());
		int[] arr = new int[i];
			Console.WriteLine("Enter the values in the array.");
			for ( i = 0; i< arr.Length; i++)
			{
				int value = Convert.ToInt32(Console.ReadLine());
				arr[i] = value;
			}
			Console.WriteLine("Elements of Array: ");
			for (i = 0; i < arr.Length; i++)
			{
				Console.Write($"{arr[i]}, ");
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
	public class Q12
	{
		public void singleDimensionalArray()
		{
			int[] arr = {1,6,2,4,5,8};

			int temp;

			for(int i = 0; i < arr.Length; i++)
			{
				for(int j = 0; j < arr.Length-1; j++)
				{
					if (arr[j] < arr[j + 1])
					{
						temp = arr[j+1];
						arr[j+1] = arr[j];
						arr[j] = temp;

					}
				}
			}
			Console.WriteLine("Decending order: ");
			for(int i =0 ; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
			Console.WriteLine($"Second greatest: {arr[1]}");
		}
	}
}

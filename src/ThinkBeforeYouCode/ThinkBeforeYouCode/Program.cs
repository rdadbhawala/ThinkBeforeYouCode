using Abstraction.ThinkBeforeYouCode.MultiLineComments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkBeforeYouCode
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 6, 4, 5, 4, 3, 7, 2 };
			SortingAlgorithm<int> algo = new SortingAlgorithm<int>();
			int[] sortedArray = algo.Sort(arr);
			foreach (int item in sortedArray)
			{
				Console.Write(item + " ");
			}
			Console.ReadLine();
		}
	}
}

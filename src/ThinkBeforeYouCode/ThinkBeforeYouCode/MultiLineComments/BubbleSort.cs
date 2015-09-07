using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.ThinkBeforeYouCode.MultiLineComments
{
	public class SortingAlgorithm<T>
		where T : IComparable<T>
	{
		public T[] Sort(T[] unsortedArray)
		{
			//int arrLength = unsortedArray.Length;
			//int outerCtr = 0;
			//int innerCtr = 0;

			//T[] sortedArray = new T[arrLength];
			//Array.Copy(unsortedArray, sortedArray, arrLength);
			
			//for (outerCtr = 0; outerCtr < arrLength; outerCtr++)
			//{
			//	for (innerCtr = outerCtr + 1; innerCtr < arrLength; innerCtr++)
			//	{
			//		T outerItem = sortedArray[outerCtr];
			//		T innerItem = sortedArray[innerCtr];

			//		int diff = outerItem.CompareTo(innerItem);
			//		if (diff > 0)
			//		{
			//			sortedArray[innerCtr] = outerItem;
			//			sortedArray[outerCtr] = innerItem;
			//		}
			//	}
			//}

			//return sortedArray;

			int arrLength = unsortedArray.Length;
			int sortedItemsCount = 0;
			int insertIndex = 0;
			int diff = 0;

			T[] sortedArray = new T[arrLength];
			for (sortedItemsCount = 0; sortedItemsCount < arrLength; sortedItemsCount++)
			{
				T unsortedItem = unsortedArray[sortedItemsCount];
				for (insertIndex = sortedItemsCount; insertIndex > 0; insertIndex--)
				{
					T sortedItem = sortedArray[insertIndex - 1];
					diff = sortedItem.CompareTo(unsortedItem);
					if (diff > 0)
					{
						sortedArray[insertIndex] = sortedItem;
					}
					else
					{
						break;
					}
				}
				sortedArray[insertIndex] = unsortedItem;
			}

			return sortedArray;
		}
	}
}

namespace DSA.Basics.BubbleSort
{
	public class BubbleSort
	{
		public static void Sort(int[] array, int length)
		{
			int index, secondIndex, tempIndex, swaps;

			for (index = length - 2; index >= 0; index--)
			{
				swaps = 0;
				for (secondIndex = 0; secondIndex <= index; secondIndex++)
				{
					if (array[secondIndex] > array[secondIndex + 1])
					{
						tempIndex = array[secondIndex];
						array[secondIndex] = array[secondIndex + 1];
						array[secondIndex + 1] = tempIndex;
						swaps++;
					}
				}
				if (swaps == 0)
					break;
			}
		}
	}
}
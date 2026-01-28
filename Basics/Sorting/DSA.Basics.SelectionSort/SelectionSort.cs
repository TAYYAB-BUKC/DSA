namespace DSA.Basics.SelectionSort
{
	public class SelectionSort
	{
		public static void Sort(int[] array, int length)
		{
			int minIndex, tempIndex, index, secondIndex;

			for (index = 0; index < length - 1; index++)
			{
				minIndex = index;
				for (secondIndex = index + 1; secondIndex < length; secondIndex++)
				{
					if (array[secondIndex] < array[minIndex])
						minIndex = secondIndex;
				}
				if (index != minIndex)
				{
					tempIndex = array[index];
					array[index] = array[minIndex];
					array[minIndex] = tempIndex;
				}
			}
		}
	}
}
namespace DSA.Basics.InsertionSort
{
	public class InsertionSort
	{
		public static void Sort(int[] array, int length)
		{
			int index, secondIndex, tempIndex;
			for (index = 1; index < length; index++)
			{
				tempIndex = array[index];

				for (secondIndex = index - 1; secondIndex >= 0 && array[secondIndex] > tempIndex; secondIndex--)
					array[secondIndex + 1] = array[secondIndex];

				array[secondIndex + 1] = tempIndex;
			}
		}
	}
}
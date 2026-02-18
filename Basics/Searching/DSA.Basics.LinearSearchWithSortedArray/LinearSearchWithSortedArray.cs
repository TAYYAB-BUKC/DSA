namespace DSA.Basics.LinearSearchWithSortedArray
{
	public class LinearSearchWithSortedArray
	{
		public static int Search(int[] array, int length, int searchValue)
		{
			int index;
			for (index = 0; index < length; index++)
			{
				if (array[index] >= searchValue)
					break;
			}

			if (array[index] == searchValue)
				return index;
			else
				return -1;
		}
	}
}
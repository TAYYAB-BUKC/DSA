namespace DSA.Basics.LinearSearchWithSentinel
{
	public class LinearSearchWithSentinel
	{
		public static int Search(int[] array, int length, int searchValue)
		{
			array[length] = searchValue;

			int index = 0;
			while (searchValue != array[index])
				index++;

			if (index < length)
				return index;
			else
				return -1;
		}
	}
}
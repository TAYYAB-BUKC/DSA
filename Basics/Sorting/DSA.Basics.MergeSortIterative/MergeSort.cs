namespace DSA.Basics.MergeSortIterative
{
	public class MergeSort
	{
		private static void Copy(int[] finalArray, int[] array, int length)
		{
			for (int index = 0; index < length; index++)
				finalArray[index] = array[index];
		}
	}
}
namespace DSA.Basics.MergeSortRecursive
{
	public class MergeSort
	{
		private static void Copy(int[] finalArray, int[] array, int lowerBound, int upperBound)
		{
			for (int index = lowerBound; index <= upperBound; index++)
				finalArray[index] = array[index];
		}
	}
}
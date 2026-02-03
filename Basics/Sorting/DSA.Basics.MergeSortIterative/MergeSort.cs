namespace DSA.Basics.MergeSortIterative
{
	public class MergeSort
	{
		private static void Copy(int[] finalArray, int[] array, int length)
		{
			for (int index = 0; index < length; index++)
				finalArray[index] = array[index];
		}

		private static void Merge(int[] array, int[] mergedArray, int firstLowerBound, int firstUpperBound, int secondLowerBound, int secondUpperBound)
		{
			int firstLowerBoundIndex = firstLowerBound;
			int secondLowerBoundIndex = secondLowerBound;
			int index = firstLowerBound;

			while ((firstLowerBoundIndex <= firstUpperBound) && (secondLowerBoundIndex <= secondUpperBound))
			{
				if (array[firstLowerBoundIndex] <= array[secondLowerBoundIndex])
					mergedArray[index++] = array[firstLowerBoundIndex++];
				else
					mergedArray[index++] = array[secondLowerBoundIndex++];
			}

			while (firstLowerBoundIndex <= firstUpperBound)
				mergedArray[index++] = array[firstLowerBoundIndex++];

			while (secondLowerBoundIndex <= secondUpperBound)
				mergedArray[index++] = array[secondLowerBoundIndex++];
		}

	}
}
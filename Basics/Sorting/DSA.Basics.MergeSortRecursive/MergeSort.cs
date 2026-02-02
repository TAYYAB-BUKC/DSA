namespace DSA.Basics.MergeSortRecursive
{
	public class MergeSort
	{
		private static void Copy(int[] finalArray, int[] array, int lowerBound, int upperBound)
		{
			for (int index = lowerBound; index <= upperBound; index++)
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

		public static void Sort(int[] array, int[] mergedArray, int lowerBound, int upperBound)
		{
			if (lowerBound == upperBound) /*only one element*/
				return;

			int midBound = (lowerBound + upperBound) / 2;

			Sort(array, mergedArray, lowerBound, midBound);  /* Sort array[lowerBound]....array[midBound] */
			Sort(array, mergedArray, midBound + 1, upperBound);  /* Sort array[midBound+1]....array[upperBound] */

			/* Merge array[lowerBound]...array[midBound] and array[midBound+1]....array[upperBound] to mergedArray[lowerBound]...mergedArray[upperBound] */
			Merge(array, mergedArray, lowerBound, midBound, midBound + 1, upperBound);

			/* Copy mergedArray[lowerBound]...mergedArray[upperBound] to array[lowerBound]...array[upperBound] */
			Copy(array, mergedArray, lowerBound, upperBound);
		}
	}
}
namespace DSA.Basics.MergeSortSubArray
{
	public class MergeSort
	{
		/* array[firstLowerBound]...array[firstUpperBound] and array[secondLowerBound]...array[secondUpperBound] merged to mergedArray[firstLowerBound]...mergedArray[secondUpperBound] */
		public static void MergeSubArray(int[] array, int[] mergedArray, int firstLowerBound, int firstUpperBound, int secondLowerBound, int secondUpperBound)
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
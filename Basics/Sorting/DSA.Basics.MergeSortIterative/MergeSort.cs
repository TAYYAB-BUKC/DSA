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

		private static void Sort(int[] array, int[] mergedArray, int size, int length)
		{
			int index, firstLowerBound = 0, firstUpperBound, secondLowerBound, secondUpperBound;

			while (firstLowerBound + size <= length - 1)
			{
				firstUpperBound = firstLowerBound + size - 1;
				secondLowerBound = firstLowerBound + size;
				secondUpperBound = secondLowerBound + size - 1;

				if (secondUpperBound >= length)/*if length of last sublist is less than size*/
					secondUpperBound = length - 1;

				Merge(array, mergedArray, firstLowerBound, firstUpperBound, secondLowerBound, secondUpperBound);

				firstLowerBound = secondUpperBound + 1; /*Take next two sublists for merging*/
			}

			for (index = firstLowerBound; index <= length - 1; index++)
				mergedArray[index] = array[index]; /*If any sublist is left alone*/

			Copy(array, mergedArray, length);
		}

		public static void Sort(int[] array, int length)
		{
			int[] temp = new int[length];
			int size = 1;
			while (size <= length - 1)
			{
				Sort(array, temp, size, length);
				size = size * 2;
			}
		}
	}
}
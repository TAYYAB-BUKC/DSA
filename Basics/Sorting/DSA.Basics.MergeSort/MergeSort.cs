namespace DSA.Basics.MergeSort
{
	public class MergeSort
	{
		public static void Sort(int[] firstArray, int[] secondArray, int[] mergedArray, int firstArrayLength, int secondArrayLength)
		{
			int firstArrayIndex = 0, secondArrayIndex = 0, thirdArrayIndex = 0;

			while ((firstArrayIndex <= firstArrayLength - 1) && (secondArrayIndex <= secondArrayLength - 1))
			{
				if (firstArray[firstArrayIndex] < secondArray[secondArrayIndex])
					mergedArray[thirdArrayIndex++] = firstArray[firstArrayIndex++];
				else
					mergedArray[thirdArrayIndex++] = secondArray[secondArrayIndex++];
			}

			/*copy remaining elements of firstArray, array secondArray finished */
			while (firstArrayIndex <= firstArrayLength - 1)
				mergedArray[thirdArrayIndex++] = firstArray[firstArrayIndex++];

			/*copy remaining elements of secondArray, array firstArray finished */
			while (secondArrayIndex <= secondArrayLength - 1)
				mergedArray[thirdArrayIndex++] = secondArray[secondArrayIndex++];
		}
	}
}
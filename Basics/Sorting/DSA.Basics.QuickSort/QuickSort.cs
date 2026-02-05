namespace DSA.Basics.QuickSort
{
	public class QuickSort
	{
		private static int Partition(int[] array, int lowerBound, int upperBound)
		{
			int temp, index, secondIndex, pivot;

			pivot = array[lowerBound];

			index = lowerBound + 1; /*moves from left to right*/
			secondIndex = upperBound;    /*moves from right to left*/

			while (index <= secondIndex)
			{
				while (array[index] < pivot && index < upperBound)
					index++;

				while (array[secondIndex] > pivot)
					secondIndex--;

				if (index < secondIndex) /*swap array[index] and array[secondIndex]*/
				{
					temp = array[index];
					array[index] = array[secondIndex];
					array[secondIndex] = temp;
					index++;
					secondIndex--;
				}
				else /*found proper place for pivot*/
					break;
			}

			/* Proper place for pivot is secondIndex */
			array[lowerBound] = array[secondIndex];
			array[secondIndex] = pivot;

			return secondIndex;
		}
	}
}
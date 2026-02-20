namespace DSA.Basics.BinarySearch
{
	public class BinarySearch
	{
		public int Search(int[] array, int target)
		{
			int left = 0;
			int right = array.Length - 1;
			while (left <= right)
			{
				int mid = left + (right - left) / 2;
				if (array[mid] == target)
					return mid; // Target found at index mid
				else if (array[mid] < target)
					left = mid + 1; // Search in the right half
				else
					right = mid - 1; // Search in the left half
			}
			return -1; // Target not found
		}
	}
}
namespace DSA.Basics.BinarySearchRecursive
{
	public class BinarySearchRecursive
	{
		public static int Search(int[] array, int target)
		{
			return Search(array, target, 0, array.Length - 1);
		}

		private static int Search(int[] array, int target, int first, int last)
		{
			if (first > last)
				return -1;

			int mid = (last + first) / 2;
			
			if (array[mid] == target)
				return mid;
			else if (array[mid] > target)
				return Search(array, target, first, mid - 1);
			else
				return Search(array, target, mid + 1, last);
		}
	}
}
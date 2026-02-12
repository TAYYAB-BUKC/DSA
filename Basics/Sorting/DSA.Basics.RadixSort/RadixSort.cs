namespace DSA.Basics.RadixSort
{
	public class RadixSort
	{
		/*Returns number of digits in the largest element of the list */
		public static int DigitsInLargest(Node start)
		{
			/*Find largest element*/
			int large = 0;
			Node node = start;
			while (node != null)
			{
				if (node.info > large)
					large = node.info;
				node = node.link;
			}

			/*Find number of digits in largest element*/
			int ndigits = 0;
			while (large != 0)
			{
				ndigits++;
				large /= 10;
			}
			return ndigits;
		}
	}
}

namespace DSA.Basics.RadixSort
{
	public class RadixSort
	{
		/*Returns kth digit from right in the number*/
		public static int Digit(int info, int postition)
		{
			int digit = 0, index;
			for (index = 1; index <= postition; index++)
			{
				digit = info % 10;
				info /= 10;
			}
			return digit;
		}
	}
}
namespace DSA.Basics.ShellSort
{
	public class ShellSort
	{
		public static void Sort(int[] array, int length)
		{
			int index, secondIndex, tempIndex, value;

			Console.Write("Enter maximum increment(odd value) : ");
			value = Convert.ToInt32(Console.ReadLine());

			while (value >= 1)
			{
				for (index = value; index < length; index++)
				{
					tempIndex = array[index];
					for (secondIndex = index - value; secondIndex >= 0 && array[secondIndex] > tempIndex; secondIndex = secondIndex - value)
						array[secondIndex + value] = array[secondIndex];
					array[secondIndex + value] = tempIndex;
				}
				value = value - 2;
			}
		}
	}
}
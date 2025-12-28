namespace DSA.Basics.ParenthesisProject
{
	public class StackUsingArray
	{
		private int[] stackArray;
		private int top;

		public StackUsingArray()
		{
			stackArray = new int[10];
			top = -1;
		}

		public StackUsingArray(int maxSize)
		{
			stackArray = new int[maxSize];
			top = -1;
		}
	}
}
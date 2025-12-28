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

		public int Size()
		{
			return top + 1;
		}

		public bool IsEmpty()
		{
			return top == -1;
		}

		public bool IsFull()
		{
			return top == stackArray.Length - 1;
		}
	}
}
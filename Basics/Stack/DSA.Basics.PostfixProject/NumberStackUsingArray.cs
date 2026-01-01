namespace DSA.Basics.PostfixProject
{
	public class NumberStackUsingArray
	{
		private int[] stackArray;
		private int top;

		public NumberStackUsingArray()
		{
			stackArray = new int[10];
			top = -1;
		}

		public NumberStackUsingArray(int maxSize)
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

		public void Push(int value)
		{
			if (IsFull())
			{
				Console.WriteLine("Stack is in Overflow state");
				return;
			}
			top++;
			stackArray[top] = value;
		}
	}
}
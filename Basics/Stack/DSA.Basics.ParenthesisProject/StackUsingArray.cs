namespace DSA.Basics.ParenthesisProject
{
	public class StackUsingArray
	{
		private char[] stackArray;
		private int top;

		public StackUsingArray()
		{
			stackArray = new char[10];
			top = -1;
		}

		public StackUsingArray(int maxSize)
		{
			stackArray = new char[maxSize];
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

		public int Pop()
		{
			int value;
			if (IsEmpty())
			{
				Console.WriteLine("Stack is in Underflow state");
				return -1;
			}
			value = stackArray[top];
			top--;
			return value;
		}

		public int Peek()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Stack is in Underflow state");
				return -1;
			}
			return stackArray[top];
		}

		public void Display()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Stack is in Underflow state");
				return;
			}

			Console.WriteLine("Stack is : ");
			for (int i = top; i >= 0; i--)
				Console.Write(stackArray[i] + "\t");

			Console.WriteLine();
		}
	}
}
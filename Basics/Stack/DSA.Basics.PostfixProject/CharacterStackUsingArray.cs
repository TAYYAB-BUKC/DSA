namespace DSA.Basics.PostfixProject
{
	public class CharacterStackUsingArray
	{
		private char[] stackArray;
		private int top;

		public CharacterStackUsingArray()
		{
			stackArray = new char[10];
			top = -1;
		}

		public CharacterStackUsingArray(int maxSize)
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

		public void Push(char value)
		{
			if (IsFull())
			{
				Console.WriteLine("Stack is in Overflow state");
				return;
			}
			top++;
			stackArray[top] = value;
		}

		public char? Pop()
		{
			char? value;
			if (IsEmpty())
			{
				Console.WriteLine("Stack is in Underflow state");
				return null!;
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
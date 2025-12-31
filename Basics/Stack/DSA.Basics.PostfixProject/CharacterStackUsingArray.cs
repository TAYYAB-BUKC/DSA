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
	}
}
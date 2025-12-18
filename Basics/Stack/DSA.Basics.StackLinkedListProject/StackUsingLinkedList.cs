namespace DSA.Basics.StackLinkedListProject
{
	public class StackUsingLinkedList
	{
		public Node top { get; set; } = null!;

		public int Size()
		{
			Node node = top;
			int counter = 0;
			while (node != null)
			{
				counter++;
				node = node.link;
			}
			return counter;
		}

		public bool IsEmpty()
		{
			return top is null;
		}

		public void Push(int info)
		{
			Node node = new Node(info);
			node.link = top;
			top = node;
		}

		public int Pop()
		{
			int value;
			if (IsEmpty())
			{
				Console.WriteLine("StackUsingLinkedList is in Underflow state");
				return -1;
			}

			value = top.info;
			top = top.link;
			return value;
		}

		public int Peek()
		{
			if (IsEmpty())
			{
				Console.WriteLine("StackUsingLinkedList is in Underflow state");
				return -1;
			}

			return top.info;
		}

		public void Display()
		{
			if (IsEmpty())
			{
				Console.WriteLine("StackUsingLinkedList is in Underflow state");
				return;
			}

			Node node = top;
			while (node != null)
			{
				Console.Write($"{node.info}\t");
				node = node.link;
			}
			Console.WriteLine();
		}
	}
}

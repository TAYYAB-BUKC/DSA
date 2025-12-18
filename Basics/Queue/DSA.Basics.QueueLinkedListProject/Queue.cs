namespace DSA.Basics.QueueLinkedListProject
{
	public class Queue
	{
		private Node front;
		private Node rear;

		public Queue()
		{
			front = null!;
			rear = null!;
		}

		public int Size()
		{
			int counter = 0;
			Node node = front;
			while (node != null)
			{
				node = node.link;
				counter++;
			}
			return counter;
		}

		public bool IsEmpty()
		{
			return front is null;
		}

		public void Display()
		{
			Node node = front;
			if (IsEmpty())
			{
				Console.WriteLine("Queue is empty");
				return;
			}

			Console.WriteLine("Queue is : ");
			while (node != null)
			{
				Console.Write($"{node.info}\t");
				node = node.link;
			}
			Console.WriteLine();
		}

		public int Peek()
		{
			if (IsEmpty())
			{
				Console.WriteLine($"{nameof(Queue)} is in underflow state");
				return -1;
			}
			return front.info;
		}

		public void Insert(int info)
		{
			Node node = new Node(info);

			if (front is null)
				front = node;
			else
				rear.link = node;

			rear = node;
		}

		public int Delete()
		{
			int value;
			if (IsEmpty())
			{
				Console.WriteLine($"{nameof(Queue)} is in underflow state");
				return -1;
			}

			value = front.info;
			front = front.link;
			return value;
		}
	}
}
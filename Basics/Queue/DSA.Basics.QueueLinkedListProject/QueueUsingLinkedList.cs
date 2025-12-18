namespace DSA.Basics.QueueLinkedListProject
{
	public class QueueUsingLinkedList
	{
		private Node front;
		private Node rear;

		public QueueUsingLinkedList()
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
				Console.WriteLine("QueueUsingLinkedList is empty");
				return;
			}

			Console.WriteLine("QueueUsingLinkedList is : ");
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
				Console.WriteLine($"{nameof(QueueUsingLinkedList)} is in underflow state");
				return -1;
			}
			return front.info;
		}

		public void Enqueue(int info)
		{
			Node node = new Node(info);

			if (front is null)
				front = node;
			else
				rear.link = node;

			rear = node;
		}

		public int Dequeue()
		{
			int value;
			if (IsEmpty())
			{
				Console.WriteLine($"{nameof(QueueUsingLinkedList)} is in underflow state");
				return -1;
			}

			value = front.info;
			front = front.link;
			return value;
		}
	}
}
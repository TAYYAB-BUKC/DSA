namespace DSA.Basics.QueueUsingCircularLinkedListProject
{
	public class QueueUsingCircularLinkedList
	{
		private Node rear = null!;

		public bool IsEmpty()
		{
			return rear is null;
		}

		public int Size()
		{
			if (IsEmpty())
				return -1;

			int counter = 0;
			Node node = rear.link;
			do
			{
				counter++;
				node = node.link;
			} while (node != rear.link);
			return counter;
		}

		public void Display()
		{
			Node node = rear.link;
			if (IsEmpty())
			{
				Console.WriteLine("Queue is empty");
				return;
			}

			Console.WriteLine("Queue is : ");
			do
			{
				Console.Write($"{node.info}\t");
				node = node.link;
			} while (node != rear.link);
			Console.WriteLine();
		}

		public int Peek()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue is in underflow state");
				return -1;
			}
			return rear.link.info;
		}

		public void Enqueue(int info)
		{
			Node newNode = new Node(info);

			if (IsEmpty())
			{
				rear = newNode;
				rear.link = rear;
			}
			else
			{
				newNode.link = rear.link;
				rear.link = newNode;
				rear = newNode;
			}
		}

		public int Dequeue()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue is in underflow state");
				return -1;
			}

			Node node;
			if (rear.link == rear)
			{
				node = rear;
				rear = null!;
			}
			else
			{
				node = rear.link;
				rear.link = node.link;
			}
			return node.info;
		}
	}
}
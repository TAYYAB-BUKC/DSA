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
	}
}
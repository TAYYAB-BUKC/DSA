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
				Console.WriteLine($"{nameof(QueueUsingCircularLinkedList)} is empty");
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
	}
}
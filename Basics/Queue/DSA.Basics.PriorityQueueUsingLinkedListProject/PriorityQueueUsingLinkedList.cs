namespace DSA.Basics.PriorityQueueUsingLinkedListProject
{
	public class PriorityQueueUsingLinkedList
	{
		private Node front = null!;

		public bool IsEmpty()
		{
			return front is null;
		}

		public void Display()
		{
			Node node = front;
			if (IsEmpty())
			{
				Console.WriteLine("Queue is in underflow state");
				return;
			}
			else
			{
				Console.WriteLine("Queue is :");
				Console.WriteLine("Priority\tElement");
				while (node != null)
				{
					Console.WriteLine($"{node.priority}\t{node.info}");
					node = node.link;
				}
			}
			Console.WriteLine();
		}

		public void Insert(int element, int priority)
		{
			Node newNode, node;

			newNode = new Node(element, priority);

			/*Queue is empty or element to be added has priority more than first element*/
			if (IsEmpty() || priority < front.priority)
			{
				newNode.link = front;
				front = newNode;
			}
			else
			{
				node = front;
				while (node.link != null && node.link.priority <= priority)
					node = node.link;

				newNode.link = node.link;
				node.link = newNode;
			}
		}

		public int Delete()
		{
			int value;
			if (IsEmpty())
			{
				Console.WriteLine("Queue is in underflow state");
				return;
			}
			else
			{
				value = front.info;
				front = front.link;
			}
			return value;
		}
	}
}
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
	}
}
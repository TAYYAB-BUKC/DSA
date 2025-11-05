namespace DSA.Basics.SingleLinkedList
{
	public class SingleLinkedList
	{
		private Node start { get; set; } = null!;

		public SingleLinkedList()
		{
			Node first = new Node(10);
			Node second = new Node(20);
			Node third = new Node(30);
			Node fourth = new Node(40);
			Node fifth = new Node(50);

			// Linking nodes
			first.link = second;
			second.link = third;
			third.link = fourth;
			fourth.link = fifth;

			// Assign head
			start = first;
		}

		public void DisplayList()
		{
			if(start is null)
			{
				Console.WriteLine("LinkedList is empty.");
				return;
			}

			Console.WriteLine("LinkedList Items");
			Node node = start;
			while(node != null)
			{
				Console.Write($"{node.info}\t");
				node = node.link;
			}
		}
	}
}
namespace DSA.Basics.SingleLinkedList
{
	public class SingleLinkedList
	{
		private Node start { get; set; } = null!;

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

		public void CountNodes()
		{
			if (start is null)
			{
				Console.WriteLine("0 Items found in LinkedList.");
				return;
			}

			Node node = start;
			int count = 0;
			while (node != null)
			{
				count++;
				node = node.link;
			}
			
			Console.WriteLine($"{count} Items found in LinkedList.");
		}

		public void SearchList(int numberToBeSearched)
		{
			if (start is null)
			{
				Console.WriteLine($"{numberToBeSearched} not found in LinkedList.");
				return;
			}

			Node node = start;
			int position = 0;
			while (node != null)
			{
				if (node.info == numberToBeSearched)
					break;
				position++;
				node = node.link;
			}

			if(node is null)
			{
				Console.WriteLine($"{numberToBeSearched} not found in LinkedList.");
			}
			else
			{
				Console.WriteLine($"{numberToBeSearched} found in LinkedList at position {position}.");
			}
		}

		public void InsertAtBeginning(int info)
		{
			Node newNode = new Node(info);
			newNode.link = start;
			start = newNode;
		}

		public void InsertAtEnd(int info)
		{
			Node newNode = new Node(info);
			if (start is null)
			{
				start = newNode;
				return;
			}
			else
			{
				Node node = start;
				while (node.link != null)
				{
					node = node.link;
				}

				node.link = newNode;
			}
		}

		public void CreateList(int numberOfNodes)
		{
			for (int i = 0; i < numberOfNodes; i++)
			{
				InsertAtEnd(new Random().Next(i, 1000));
			}
		}
	}
}
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

		public void InsertBefore(int info, int previousInfo)
		{
			Node newNode = new Node(info);

			if(start is null)
			{
				start = newNode;
				return;
			}

			Node node = start;
			while (node != null)
			{
				if (node.link?.info == previousInfo)
					break;
				node = node.link;
			}
			
			if(node is not null)
			{
				newNode.link = node.link;
				node.link = newNode;
			}
			else
			{
				Console.WriteLine($"Node not found with info {previousInfo}");
			}
		}

		public void InsertAfter(int info, int nextInfo)
		{
			Node newNode = new Node(info);
			Node node = start;
			while(node != null)
			{
				if(node.info == nextInfo)
					break;
				node = node.link;
			}

			if (node?.link is null)
			{
				node!.link = newNode;
			}
			else
			{
				newNode.link = node.link;
				node.link = newNode;
			}
		}

		public void InsertAtPosition(int info, int position)
		{
			Node newNode = new Node(info);
			Node node = start;
			for (int i = 0; i < (position - 1) && node.link != null; i++)
			{
				node = node.link;
			}
			
			newNode.link = node.link!;
			node.link = newNode;
		}

		public void DeleteFirstNode()
		{
			if (start is null)
			{
				return;
			}

			start = start.link;
		}

		public void DeleteLastNode()
		{
			if (start is null)
			{
				Console.WriteLine("List is empty.");
				return;
			}

			if (start.link == null)
			{
				start = null!;
				return;
			}

			Node node = start;
			while (node.link.link != null)
			{
				node = node.link;
			}

			node.link = null!;
		}

		public void DeleteNode(int info)
		{
			if (start is null)
			{
				Console.WriteLine("List is empty.");
				return;
			}

			if (start.info == info)
			{
				start = start.link;
				return;
			}

			Node node = start;
			while (node.link != null)
			{
				if (node.link.info == info)
					break;
				node = node.link;
			}

			if (node.link is null)
				Console.WriteLine($"Element {info} not in list");
			else
				node!.link = node.link.link;			
		}

		public void ReverseList()
		{
			Node previous = null!, next = null!;

			Node node = start;
			while (node != null)
			{
				next = node.link;
				node.link = previous;
				previous = node;
				node = next;
			}

			start = previous;
		}
	}
}
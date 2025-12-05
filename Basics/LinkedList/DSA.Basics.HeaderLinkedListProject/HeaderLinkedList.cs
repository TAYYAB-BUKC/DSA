namespace DSA.Basics.HeaderLinkedListProject
{
	public class HeaderLinkedList
	{
		public Node head { get; set; } = new Node(0);

		public void DisplayList()
		{
			if(head.link is null)
			{
				Console.WriteLine("List is empty\n");
				return;
			}

			Node node = head.link;
			Console.Write("Current List:\n");
			while (node != null)
			{
				Console.Write($"{node.info}\t");
				node = node.link;
			}
			Console.WriteLine();
		}

		public void InsertAtBeginning(int info)
		{
			Node newNode = new Node(info);
			newNode.link = head.link;
			head.link = newNode;
		}

		public void InsertBefore(int info, int newInfo)
		{
			Node newNode = new(newInfo);
			Node node = head;
			while (node.link != null)
			{
				if (node.link.info == info)
					break;
				node = node.link;
			}

			if (node.link == null)
				Console.WriteLine(info + " not present in the list");
			else
			{
				newNode.link = node.link;
				node.link = newNode;
			}
		}

		public void InsertAtEnd(int info)
		{
			Node newNode = new(info);
			Node node = head;
			while (node.link != null)
			{
				node = node.link;
			}

			node.link = newNode;
		}

		public void InsertAtPosition(int info, int position)
		{
			Node newNode = new(info);
			Node node = head;
			int index;
			for (index = 1; index <= position - 1 && node is not null; index++)
			{
				node = node.link;
			}

			if(node is null)
				Console.WriteLine("You can insert only upto " + (index - 1) + "th position\n\n");
			else
			{
				newNode.link = node.link;
				node.link = newNode;
			}
		}

		public void DeleteNode(int info)
		{
			Node node = head.link;
			while (node.link is not null)
			{
				if (node.link.info == info)
					break;
				node = node.link;
			}

			if (node is null)
			{
				Console.WriteLine($"{info} is not present in the list.");
			}
			else
			{
				node.link = node?.link?.link;
			}
		}

		public void Reverse()
		{
			Node previous, node, next;
			previous = null!;
			node = head.link;
			while (node != null)
			{
				next = node.link;
				node.link = previous;
				previous = node;
				node = next;
			}
			head.link = previous;
		}
	}
}
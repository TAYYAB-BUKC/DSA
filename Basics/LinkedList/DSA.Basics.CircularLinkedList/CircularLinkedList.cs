namespace DSA.Basics.CircularLinkedList
{
	public class CircularLinkedList
	{
		public Node end { get; set; } = null!;

		public void DisplayList()
		{
			if(end is null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			Node node = end.link;
			do
			{
				if (node is null)
					break;
				Console.WriteLine($"{node.info}\t");
				node = node.link;
			}
			while (node != end.link);
			Console.WriteLine();
		}

		public void InsertAtBeginning(int info)
		{
			Node newNode = new Node(info);
			if (end is null)
			{
				end = newNode;
				end.link = newNode;
				return;
			}

			newNode.link = end.link;
			end.link = newNode;
		}

		public void InsertAtEnd(int info)
		{
			Node newNode = new Node(info);
			if (end is null)
			{
				end = newNode;
				end.link = newNode;
				return;
			}

			newNode.link = end.link;
			end.link = newNode;
			end = newNode;
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

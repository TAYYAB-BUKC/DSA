namespace DSA.Basics.SortedLinkedListProject
{
	public class SortedLinkedList
	{
		private Node start;

		public SortedLinkedList()
		{
			start = null!;
		}

		public void InsertInOrder(int data)
		{
			Node newNode = new Node(data);

			/*List empty or new node to be inserted before first node*/
			if (start == null || data < start.info)
			{
				newNode.link = start;
				start = newNode;
				return;
			}

			Node node = start;
			while (node.link != null && node.link.info <= data)
			{
				node = node.link;
			}
			
			newNode.link = node.link;
			node.link = newNode;
		}

		public void DisplayList()
		{
			if (start == null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			Node node = start;
			while (node != null)
			{
				Console.Write($"{node.info}\t");
				node = node.link;
			}
			
			Console.WriteLine("");
		}

		public void CreateList(int numberOfNodes)
		{
			for (int index = 0; index < numberOfNodes; index++)
			{
				InsertInOrder(new Random().Next(0, 1000));
			}
			
			Console.WriteLine();
		}

		public void Search(int info)
		{
			if (start is null)
			{
				Console.WriteLine("List is empty.");
				return;
			}

			Node node = start;
			int position = 1;
			while (node is not null && node.info <= info)
			{
				if (node.info == info)
					break;
				position++;
				node = node.link;
			}

			if (node is not null && node?.info != info)
				Console.WriteLine($"{info} is not found in the list.");
			else
				Console.WriteLine($"{info} is found at position {position} in the list.");
		}
	}
}
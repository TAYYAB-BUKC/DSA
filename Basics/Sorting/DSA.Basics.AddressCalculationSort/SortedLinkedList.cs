namespace DSA.Basics.AddressCalculationSort
{
	public class SortedLinkedList
	{
		private Node start { get; set; } = null!;

		public Node GetStart()
		{
			return start;
		}

		public void DisplayList()
		{
			if (start is null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			Console.Write("List is :   ");
			Node node = start;
			while (node != null)
			{
				Console.Write(node.info + "  ");
				node = node.link;
			}
			Console.WriteLine();
		}

		public void InsertInOrder(int info)
		{
			Node newNode = new Node(info);

			/*List empty or new node to be inserted before first node*/
			if (start is null || info < start.info)
			{
				newNode.link = start;
				start = newNode;
				return;
			}

			Node node = start;
			while (node.link != null && node.link.info <= info)
			{
				node = node.link;
			}

			newNode.link = node.link;
			node.link = newNode;
		}
	}
}
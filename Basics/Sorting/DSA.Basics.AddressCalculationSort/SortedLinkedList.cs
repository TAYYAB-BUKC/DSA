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

		public void CreateList()
		{
			int index, numberOfNodes, info;

			Console.Write("Enter the number of nodes : ");
			numberOfNodes = Convert.ToInt32(Console.ReadLine());

			if (numberOfNodes < 1)
				return;

			for (index = 1; index <= numberOfNodes; index++)
			{
				Console.Write("Enter the element to be inserted : ");
				info = Convert.ToInt32(Console.ReadLine());
				InsertInOrder(info);
			}
		}

		private int Hash(int info, int large)
		{
			float temp;
			temp = (float)info / large;
			return (int)(temp * 5);
		}
	}
}
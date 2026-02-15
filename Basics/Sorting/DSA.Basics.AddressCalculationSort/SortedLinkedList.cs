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
	}
}
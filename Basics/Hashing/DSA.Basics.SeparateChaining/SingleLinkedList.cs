namespace DSA.Basics.SeparateChaining
{
	public class SingleLinkedList
	{
		private Node start = default!;

		public void DisplayList()
		{
			if (start is null)
			{
				Console.WriteLine("LinkedList is empty.");
				return;
			}

			Console.WriteLine("LinkedList Items");
			Node node = start;
			while (node != null)
			{
				Console.Write($"{node.info}\t");
				node = node.link;
			}
			Console.WriteLine();
		}
	}
}
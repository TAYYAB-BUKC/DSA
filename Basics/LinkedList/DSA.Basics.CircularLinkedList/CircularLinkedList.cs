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
				Console.WriteLine($"{node.info}\t");
				node = node.link;
			}
			while (node != end.link);
			Console.WriteLine();
		}
	}
}

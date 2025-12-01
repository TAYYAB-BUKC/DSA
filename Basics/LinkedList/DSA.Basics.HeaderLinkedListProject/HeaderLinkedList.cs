namespace DSA.Basics.HeaderLinkedListProject
{
	public class HeaderLinkedList
	{
		public Node head { get; set; } = null!;

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
	}
}
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
	}
}
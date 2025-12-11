namespace DSA.Basics.StackLinkedListProject
{
	public class Stack
	{
		public Node top { get; set; } = null!;

		public int Size()
		{
			Node node = top;
			int counter = 0;
			while (node != null)
			{
				counter++;
				node = node.link;
			}
			return counter;
		}

		public bool IsEmpty()
		{
			return top is null;
		}
	}
}

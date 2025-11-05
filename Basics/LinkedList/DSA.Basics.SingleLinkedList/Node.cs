namespace DSA.Basics.SingleLinkedList
{
	public class Node
	{
		public int info { get; set; }
		public Node link { get; set; }

		public Node(int info)
		{
			this.info = info;
			this.link = null!;
		}
	}
}
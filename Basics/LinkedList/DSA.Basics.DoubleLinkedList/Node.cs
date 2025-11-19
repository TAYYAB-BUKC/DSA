namespace DSA.Basics.DoubleLinkedList
{
	public class Node
	{
		public Node previous { get; set; }
		public int info { get; set; }
		public Node next { get; set; }

		public Node(int info)
		{
			this.previous = null;
			this.info = info;
			this.next = null;
		}
	}
}
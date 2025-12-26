namespace DSA.Basics.PriorityQueueUsingLinkedListProject
{
	public class Node
	{
		public int priority;
		public int info;
		public Node link;

		public Node(int info, int priority)
		{
			this.info = info;
			this.priority = priority;
			link = null!;
		}
	}
}
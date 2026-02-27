namespace DSA.Basics.SeparateChaining
{
	public class Node
	{
		public Student info;
		public Node link;

		public Node(Student info)
		{
			this.info = info;
			link = null!;
		}
	}
}
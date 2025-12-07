namespace DSA.Basics.SortedLinkedListProject
{
	public class SortedLinkedList
	{
		private Node start;

		public SortedLinkedList()
		{
			start = null!;
		}

		public void InsertInOrder(int data)
		{
			Node newNode = new Node(data);

			/*List empty or new node to be inserted before first node*/
			if (start == null || data < start.info)
			{
				newNode.link = start;
				start = newNode;
				return;
			}

			Node node = start;
			while (node.link != null && node.link.info <= data)
			{
				node = node.link;
			}
			
			newNode.link = node.link;
			node.link = newNode;
		}
	}
}
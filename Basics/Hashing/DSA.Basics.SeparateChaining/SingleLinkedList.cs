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

		public void InsertAtBeginning(Student info)
		{
			Node newNode = new Node(info);
			newNode.link = start;
			start = newNode;
		}

		public Student Search(int id)
		{
			Node node = start;
			while (node != null)
			{
				if (node.info.GetStudentId() == id)
					break;
				node = node.link;
			}

			if (node is null)
			{
				Console.WriteLine(id + " not found in list");
				return null!;
			}
			else
				return node.info;
		}

		public void Delete(int info)
		{
			if (start is null)
			{
				Console.WriteLine("List is empty.");
				return;
			}

			if (start.info.GetStudentId() == info)
			{
				start = start.link;
				return;
			}

			Node node = start;
			while (node.link != null)
			{
				if (node.link.info.GetStudentId() == info)
					break;

				node = node.link;
			}

			if (node.link is null)
				Console.WriteLine($"Element {info} not in list");
			else
				node!.link = node.link.link;
		}
	}
}
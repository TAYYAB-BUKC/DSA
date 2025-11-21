using System;

namespace DSA.Basics.DoubleLinkedList
{
	public class DoubleLinkedList
	{
		public Node start { get; set; } = null;

		public void DisplayList()
		{
			if (start == null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			Node node = start;
			Console.WriteLine("List Items: ");
			while (node != null)
			{
				Console.Write($"{node.info}");
				node = node.next;
			}
			Console.WriteLine();
		}

		public void InsertInEmptyList(int info)
		{
			Node node = new Node(info);
			start = node;
			Console.WriteLine();
		}
	}
}
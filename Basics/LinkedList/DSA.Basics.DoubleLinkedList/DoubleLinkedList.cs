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
				Console.Write($"{node.info}\t");
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

		public void InsertAtBeginning(int info)
		{
			Node node = new Node(info);
			node.next = start;
			start.previous = node;
			start = node;
			Console.WriteLine();
		}

		public void InsertAtEnd(int info)
		{
			Node newNode = new Node(info);

			Node node = start;
			while (node.next != null)
			{
				node = node.next;
			}

			node.next = newNode;
			newNode.previous = node;
			Console.WriteLine();
		}
	}
}
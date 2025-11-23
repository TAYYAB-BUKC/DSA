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

		public void InsertAfterNode(int info, int newInfo)
		{
			Node newNode = new Node(newInfo);

			Node node = start;
			while (node != null)
			{
				if (node.info == info)
					break;
				node = node.next;
			}

			if (node != null)
			{
				newNode.previous = node;
				newNode.next = node.next;
				if (node.next != null)
					node.next.previous = newNode; /*should not be done when p refers to last node*/
				node.next = newNode;
			}
			else
			{
				Console.WriteLine($"{info} is not present in the list.");
			}
			Console.WriteLine();
		}

		public void InsertBeforeNode(int info, int newInfo)
		{
			Node newNode = new Node(newInfo);

			Node node = start;

			if(node.info == info)
			{
				newNode.next = start;
				start = newNode;
				return;
			}

			while (node != null)
			{
				if (node.next?.info == info)
					break;
				node = node.next;
			}

			if (node != null)
			{
				newNode.previous = node;
				newNode.next = node.next;
				node.next = newNode;
			}
			else
			{
				Console.WriteLine($"{info} is not present in the list.");
			}
			Console.WriteLine();
		}

		public void DeleteFirstNode()
		{
			if (start is null)
			{
				Console.WriteLine("List is already empty.");
				return;
			}

			if (start.next is null)
			{
				start = null;
			}

			start = start.next;
			start.previous = null;
		}

		public void DeleteLastNode()
		{
			if (start is null)
			{
				Console.WriteLine("List is already empty.");
				return;
			}

			if (start.next is null)
			{
				start = null;
				return;
			}

			Node node = start;
			while (node.next.next != null)
			{
				node = node.next;
			}

			node.next = null;
		}

		public void DeleteNode(int info)
		{
			if (start is null)
			{
				Console.WriteLine("List is already empty.");
				return;
			}

			if (start.info == info)
			{
				DeleteFirstNode();
				return;
			}

			Node node = start;
			while (node != null)
			{
				if (node.info == info)
					break;
				node = node.next;
			}

			if(node.next is null)
			{
				node.previous.next = null;
			}
			else
			{
				node.previous.next = node.next;
				node.next.previous = node.previous;
			}
		}

		public void ReverseList()
		{
			if (start is null)
				return;

			Node node = start;
			Node nextNode = node.next;
			node.next = null;
			node.previous = nextNode;
			while (nextNode != null)
			{
				nextNode.previous = nextNode.next;
				nextNode.next = node;
				node = nextNode;
				nextNode = nextNode.previous;
			}
			start = node;
		}
	}
}
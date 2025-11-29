using System.Collections.Generic;

namespace DSA.Basics.CircularLinkedList
{
	public class CircularLinkedList
	{
		public Node end { get; set; } = null!;

		public void DisplayList()
		{
			if(end is null)
			{
				Console.WriteLine("List is empty");
				return;
			}

			Node node = end.link;
			do
			{
				if (node is null)
					break;
				Console.Write($"{node.info}\t");
				node = node.link;
			}
			while (node != end.link);
			Console.WriteLine();
		}

		public void InsertAtBeginning(int info)
		{
			Node newNode = new Node(info);
			if (end is null)
			{
				end = newNode;
				end.link = newNode;
				return;
			}

			newNode.link = end.link;
			end.link = newNode;
		}

		public void InsertAtEnd(int info)
		{
			Node newNode = new Node(info);
			if (end is null)
			{
				end = newNode;
				end.link = newNode;
				return;
			}

			newNode.link = end.link;
			end.link = newNode;
			end = newNode;
		}

		public void CreateList(int numberOfNodes)
		{
			for (int i = 0; i < numberOfNodes; i++)
			{
				InsertAtEnd(new Random().Next(i, 1000));
			}
		}

		public void InsertAfter(int info, int newInfo)
		{
			Node newNode = new Node(newInfo);
			Node node = end.link;
			do
			{
				if (node.info == info)
					break;
				node = node.link;
			}
			while (node != end.link);

			if (node != end.link && node.info != info)
			{
				Console.WriteLine($"{info} not present in the list");
			}
			else
			{
				newNode.link = node.link;
				node.link = newNode;
				if (node == end)
					end = newNode;
			}
		}
		
		public void DeleteFirstNode()
		{
			if (end is null)
				return;

			if(end.link == end)
			{
				end = null!;
				return;
			}

			end.link = end.link.link;
		}

		public void DeleteLastNode()
		{
			if (end is null)
				return;

			if (end.link == end)
			{
				end = null!;
				return;
			}

			Node node = end.link;
			while (node.link != end)
			{
				node = node.link;
			}

			node.link = end.link;
			end = node;
		}

		public void DeleteNode(int info)
		{
			if (end is null)
				return;

			if (end.link == end && end.info == info)  /*Deletion of only node*/
			{
				end = null!;
				return;
			}
			if (end.link.info == info)  /*Deletion of first node*/
			{
				end.link = end.link.link;
				return;
			}

			Node node = end.link;
			while (node.link != end)
			{
				if (node.link.info == info)
					break;
				node = node.link;
			}

			node.link = node.link.link;
		}
	}
}
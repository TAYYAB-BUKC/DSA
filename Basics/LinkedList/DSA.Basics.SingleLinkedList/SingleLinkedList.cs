namespace DSA.Basics.SingleLinkedList
{
	public class SingleLinkedList
	{
		private Node start { get; set; } = null!;

		public void DisplayList()
		{
			if(start is null)
			{
				Console.WriteLine("LinkedList is empty.");
				return;
			}

			Console.WriteLine("LinkedList Items");
			Node node = start;
			while(node != null)
			{
				Console.Write($"{node.info}\t");
				node = node.link;
			}
		}

		public void CountNodes()
		{
			if (start is null)
			{
				Console.WriteLine("0 Items found in LinkedList.");
				return;
			}

			Node node = start;
			int count = 0;
			while (node != null)
			{
				count++;
				node = node.link;
			}
			
			Console.WriteLine($"{count} Items found in LinkedList.");
		}

		public void SearchList(int numberToBeSearched)
		{
			if (start is null)
			{
				Console.WriteLine($"{numberToBeSearched} not found in LinkedList.");
				return;
			}

			Node node = start;
			int position = 0;
			while (node != null)
			{
				if (node.info == numberToBeSearched)
					break;
				position++;
				node = node.link;
			}

			if(node is null)
			{
				Console.WriteLine($"{numberToBeSearched} not found in LinkedList.");
			}
			else
			{
				Console.WriteLine($"{numberToBeSearched} found in LinkedList at position {position}.");
			}
		}

		public void InsertAtBeginning(int info)
		{
			Node newNode = new Node(info);
			newNode.link = start;
			start = newNode;
		}

		public void InsertAtEnd(int info)
		{
			Node newNode = new Node(info);
			if (start is null)
			{
				start = newNode;
				return;
			}
			else
			{
				Node node = start;
				while (node.link != null)
				{
					node = node.link;
				}

				node.link = newNode;
			}
		}

		public void CreateList(int numberOfNodes)
		{
			for (int i = 0; i < numberOfNodes; i++)
			{
				InsertAtEnd(new Random().Next(i, 1000));
			}
		}

		public void InsertBefore(int info, int previousInfo)
		{
			Node newNode = new Node(info);

			if(start is null)
			{
				start = newNode;
				return;
			}

			Node node = start;
			while (node != null)
			{
				if (node.link?.info == previousInfo)
					break;
				node = node.link;
			}
			
			if(node is not null)
			{
				newNode.link = node.link;
				node.link = newNode;
			}
			else
			{
				Console.WriteLine($"Node not found with info {previousInfo}");
			}
		}

		public void InsertAfter(int info, int nextInfo)
		{
			Node newNode = new Node(info);
			Node node = start;
			while(node != null)
			{
				if(node.info == nextInfo)
					break;
				node = node.link;
			}

			if (node?.link is null)
			{
				node!.link = newNode;
			}
			else
			{
				newNode.link = node.link;
				node.link = newNode;
			}
		}

		public void InsertAtPosition(int info, int position)
		{
			Node newNode = new Node(info);
			Node node = start;
			for (int i = 0; i < (position - 1) && node.link != null; i++)
			{
				node = node.link;
			}
			
			newNode.link = node.link!;
			node.link = newNode;
		}

		public void DeleteFirstNode()
		{
			if (start is null)
			{
				return;
			}

			start = start.link;
		}

		public void DeleteLastNode()
		{
			if (start is null)
			{
				Console.WriteLine("List is empty.");
				return;
			}

			if (start.link == null)
			{
				start = null!;
				return;
			}

			Node node = start;
			while (node.link.link != null)
			{
				node = node.link;
			}

			node.link = null!;
		}

		public void DeleteNode(int info)
		{
			if (start is null)
			{
				Console.WriteLine("List is empty.");
				return;
			}

			if (start.info == info)
			{
				start = start.link;
				return;
			}

			Node node = start;
			while (node.link != null)
			{
				if (node.link.info == info)
					break;
				node = node.link;
			}

			if (node.link is null)
				Console.WriteLine($"Element {info} not in list");
			else
				node!.link = node.link.link;			
		}

		public void ReverseList()
		{
			Node previous = null!, next = null!;

			Node node = start;
			while (node != null)
			{
				next = node.link;
				node.link = previous;
				previous = node;
				node = next;
			}

			start = previous;
		}

		public void SortListByExchangingDataUsingBubbleSort()
		{
			Node node = null!, end;

			for (end = null!; end != start.link; end = node)
			{
				for (node = start; node.link != end; node = node.link)
				{
					if(node.info > node.link.info)
					{
						int temp = node.info;
						node.info = node.link.info;
						node.link.info = temp;
					}
				}
			}
		}

		public void SortListByExchangingLinkUsingBubbleSort()
		{
			Node node = null!, end, previous;

			for (end = null!; end != start; end = node)
			{
				for (previous = node = start; node.link != end; previous = node, node = node.link)
				{
					Node next = node.link;

					if (node.info > node.link.info)
					{
						node.link = next.link;
						next.link = node;

						if (node != start)
							previous.link = next;
						else
							start = next;

						Node temp = node;
						node = next;
						next = temp;
					}
				}
			}
		}

		public SingleLinkedList MergeByCreatingANewList(SingleLinkedList newList)
		{
			SingleLinkedList mergeList = new SingleLinkedList();
			mergeList.start = MergeByCreatingANewList(start, newList.start);
			return mergeList;
		}

		private Node MergeByCreatingANewList(Node node1, Node node2)
		{
			Node newListStart;

			if (node1.info <= node2.info)
			{
				newListStart = new Node(node1.info);
				node1 = node1.link;
			}
			else
			{
				newListStart = new Node(node2.info);
				node2 = node2.link;
			}

			Node pM = newListStart;

			while (node1 != null && node2 != null)
			{
				if (node1.info <= node2.info)
				{
					pM.link = new Node(node1.info);
					node1 = node1.link;
				}
				else
				{
					pM.link = new Node(node2.info);
					node2 = node2.link;
				}
				pM = pM.link;
			}

			/*If second list has finished and elements left in first list*/
			while (node1 != null)
			{
				pM.link = new Node(node1.info);
				node1 = node1.link;
				pM = pM.link;
			}

			/*If first list has finished and elements left in second list*/
			while (node2 != null)
			{
				pM.link = new Node(node2.info);
				node2 = node2.link;
				pM = pM.link;
			}
			return newListStart;
		}

		public SingleLinkedList MergeByArrangingLinks(SingleLinkedList newList)
		{
			SingleLinkedList mergeList = new SingleLinkedList();
			mergeList.start = MergeByArrangingLinks(start, newList.start);
			return mergeList;
		}

		private Node MergeByArrangingLinks(Node node1, Node node2)
		{
			Node newListStart;

			if (node1.info <= node2.info)
			{
				newListStart = new Node(node1.info);
				node1 = node1.link;
			}
			else
			{
				newListStart = new Node(node2.info);
				node2 = node2.link;
			}

			Node newListEnd = newListStart;

			while (node1 != null && node2 != null)
			{
				if (node1.info <= node2.info)
				{
					newListEnd.link = new Node(node1.info);
					node1 = node1.link;
				}
				else
				{
					newListEnd.link = new Node(node2.info);
					node2 = node2.link;
				}
				newListEnd = newListEnd.link;
			}

			/*If second list has finished and elements left in first list*/
			//while (node1 != null)
			//{
			//	newListEnd.link = new Node(node1.info);
			//	node1 = node1.link;
			//	newListEnd = newListEnd.link;
			//}

			///*If first list has finished and elements left in second list*/
			//while (node2 != null)
			//{
			//	newListEnd.link = new Node(node2.info);
			//	node2 = node2.link;
			//	newListEnd = newListEnd.link;
			//}

			/*If second list has finished and elements left in first list*/
			if (node1 != null)
			{
				newListEnd.link = node1;
			}

			/*If first list has finished and elements left in second list*/
			if (node2 != null)
			{
				newListEnd.link = node2;
			}
			return newListStart;
		}

		public void SortListByUsingRecursiveMergeSort()
		{
			start = SortListByUsingRecursiveMergeSort(start);
		}

		private Node SortListByUsingRecursiveMergeSort(Node unsortedLinkedList)
		{
			if (unsortedLinkedList is null || unsortedLinkedList.link is null)
				return unsortedLinkedList!;

			Node startNode = unsortedLinkedList;
			Node endNode = DivideLinkedList(startNode);

			Node firstPartNode = SortListByUsingRecursiveMergeSort(startNode);
			Node secondPartNode = SortListByUsingRecursiveMergeSort(endNode);
			return MergeByArrangingLinks(firstPartNode, secondPartNode);
		}

		private Node DivideLinkedList(Node startNode)
		{
			Node consecutiveNode = startNode.link.link;
			while (startNode != null && consecutiveNode != null)
			{
				startNode = startNode.link;
				consecutiveNode = consecutiveNode.link?.link;
			}

			//startNode!.link = null!;
			//return startNode;

			Node node = startNode!.link;
			startNode!.link = null!;
			return node;
		}

		public bool HasCycle()
		{
			if(FindCycle() is null)
			{
				return false;
			}
			return true;
		}

		private Node FindCycle()
		{
			if (start is null || start.link is null)
				return null!;

			Node slowReference = start, fastreference = start;

			while (fastreference != null && fastreference.link != null)
			{
				slowReference = slowReference.link;
				fastreference = fastreference.link.link;

				if(slowReference == fastreference)
				{
					return slowReference;
				}
			}
			return null!;
		}

		public void RemoveCycle()
		{
			Node cycleNode = FindCycle();
			if (cycleNode is null)
				return;

			Console.WriteLine("Node at which the cycle was detected is " + cycleNode.info);

			Node node1 = cycleNode, node2 = cycleNode;
			int cycleLength = 0;
			do
			{
				cycleLength++;
				node2 = node2.link;
			} while (node1 != node2);

			Console.WriteLine("Length of cycle is : " + cycleLength);

			int remainingListLength = 0;
			node1 = start;
			while (node1 != node2)
			{
				remainingListLength++;
				node1 = node1.link;
				node2 = node2.link;
			}

			Console.WriteLine("Number of nodes not included in the cycle are : " + remainingListLength);

			int listLength = cycleLength + remainingListLength;
			Console.WriteLine("Length of the list is : " + listLength);

			node1 = start;
			for (int i = 1; i <= listLength - 1; i++)
				node1 = node1.link;

			node1.link = null!;
		}

		public void InsertCycle(int info)
		{
			if (start == null)
				return;

			Node node = start, cycleNode = null!, previousNode = null!;

			while (node != null)
			{
				if (node.info == info)
					cycleNode = node;
				previousNode = node;
				node = node.link;
			}

			if (cycleNode is not null)
				previousNode.link = cycleNode;
			else
				Console.WriteLine(info + " not present in list");
		}



		public void ConcatenateList(SingleLinkedList list)
		{
			if (start is null)
			{
				start = list.start;
				return;
			}

			if (list.start is null)
				return;

			Node node = start;
			while (node.link != null)
			{
				node = node.link;
			}

			node.link = list.start;
		}
	}
}
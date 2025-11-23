using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Basics.DoubleLinkedList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DoubleLinkedList doubleLinkedList = new DoubleLinkedList();

			doubleLinkedList.InsertInEmptyList(10);

			doubleLinkedList.InsertAtBeginning(5);

			doubleLinkedList.InsertAtEnd(20);

			doubleLinkedList.InsertAfterNode(10, 15);

			//doubleLinkedList.InsertBeforeNode(5, 0);

			doubleLinkedList.InsertBeforeNode(50, 8);

			doubleLinkedList.DisplayList();

			doubleLinkedList.DeleteFirstNode();

			doubleLinkedList.DisplayList();

			doubleLinkedList.DeleteLastNode();

			doubleLinkedList.DisplayList();

			doubleLinkedList.InsertAtBeginning(5);

			doubleLinkedList.DisplayList();

			//doubleLinkedList.DeleteNode(15);

			doubleLinkedList.DisplayList();

			doubleLinkedList.ReverseList();

			doubleLinkedList.DisplayList();
		}
	}
}

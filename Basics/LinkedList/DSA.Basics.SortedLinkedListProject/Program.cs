// See https://aka.ms/new-console-template for more information
using DSA.Basics.SortedLinkedListProject;

//int numberOfNodes, data;

SortedLinkedList list = new();

list.DisplayList();

list.InsertInOrder(0);
list.InsertInOrder(5);
list.InsertInOrder(10);
list.InsertInOrder(15);
list.InsertInOrder(20);

//Console.Write("Enter the number of nodes : ");
//numberOfNodes = Convert.ToInt32(Console.ReadLine());

//if (numberOfNodes == 0)
//	return;

//for (int i = 1; i <= numberOfNodes; i++)
//{
//	Console.Write("Enter the element to be inserted : ");
//	data = Convert.ToInt32(Console.ReadLine());
//	list.InsertInOrder(data);
//}

list.CreateList(5);

list.DisplayList();

list.CreateList(5);

list.DisplayList();

list.Search(100);
list.Search(5);
list.Search(-5);
list.Search(20);


// See https://aka.ms/new-console-template for more information
using DSA.Basics.SortedLinkedListProject;

int numberOfNodes, data;

SortedLinkedList list = new();

list.DisplayList();

Console.Write("Enter the number of nodes : ");
numberOfNodes = Convert.ToInt32(Console.ReadLine());

if (numberOfNodes == 0)
	return;

for (int i = 1; i <= numberOfNodes; i++)
{
	Console.Write("Enter the element to be inserted : ");
	data = Convert.ToInt32(Console.ReadLine());
	list.InsertInOrder(data);
}

list.DisplayList();
using System;

namespace DSA.Basics.DoubleLinkedList
{
	public class Program
	{
		static void Main(string[] args)
		{
			int choice, data, info;

			DoubleLinkedList list = new DoubleLinkedList();
			list.CreateList(5);

			while (true)
			{
				Console.WriteLine();
				Console.WriteLine("1.Display List");
				Console.WriteLine("2.Insert in empty list");
				Console.WriteLine("3.Insert a node in beginning of the list");
				Console.WriteLine("4.Insert a node at the end of the list");
				Console.WriteLine("5.Insert a node after a specified node");
				Console.WriteLine("6.Insert a node before a specified node");
				Console.WriteLine("7.Delete first node");
				Console.WriteLine("8.Delete last node");
				Console.WriteLine("9.Delete any node");
				Console.WriteLine("10.Reverse the list");
				Console.WriteLine("11.Quit");
				Console.WriteLine("Enter your choice : ");
				choice = Convert.ToInt32(Console.ReadLine());

				if (choice == 11)
					break;

			}
			Console.WriteLine("Exiting");
		}
	}
}

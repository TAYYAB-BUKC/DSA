// See https://aka.ms/new-console-template for more information

using DSA.Basics.HeaderLinkedListProject;

HeaderLinkedList list = new HeaderLinkedList();

list.InsertAtBeginning(20);
list.InsertAtBeginning(15);
list.InsertAtBeginning(10);
list.InsertAtBeginning(5);

list.DisplayList();

Console.ReadKey();
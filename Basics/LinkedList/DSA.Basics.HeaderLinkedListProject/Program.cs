// See https://aka.ms/new-console-template for more information

using DSA.Basics.HeaderLinkedListProject;

HeaderLinkedList list = new HeaderLinkedList();

list.CreateList(5);
list.DisplayList();

list.InsertAtBeginning(25);
list.InsertAtBeginning(15);
list.InsertAtBeginning(10);
list.InsertAtBeginning(5);

list.DisplayList();

list.InsertBefore(25, 20);

list.DisplayList();

list.InsertBefore(5, 0);

list.DisplayList();

list.InsertAtEnd(30);
list.InsertAtEnd(35);
list.InsertAtEnd(40);

list.DisplayList();

list.InsertAtPosition(-15,0);
list.DisplayList();
list.InsertAtPosition(-10, 0);
list.DisplayList();
list.InsertAtPosition(-05, 0);
list.DisplayList();
list.InsertAtPosition(450, 450);
list.DisplayList();

list.Reverse();
list.DisplayList();

Console.ReadKey();
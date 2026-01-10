using DSA.Basics.TowerofHanoi;

Console.Write("Enter the number of disks : ");
int number = Convert.ToInt32(Console.ReadLine());
Hanoi.TowerofHanoi(number, 'A', 'B', 'C');

Console.ReadKey();
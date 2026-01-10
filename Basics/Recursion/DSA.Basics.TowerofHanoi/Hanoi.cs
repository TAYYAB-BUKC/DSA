namespace DSA.Basics.TowerofHanoi
{
    public class Hanoi
    {
        public static void TowerofHanoi(int number, char source, char temp, char dest)
        {
            if (number == 1)
            {
                Console.WriteLine("Move Disk " + number + " from " + source + "-->" + dest);
                return;
            }

            TowerofHanoi(number - 1, source, dest, temp);
            Console.WriteLine("Move Disk " + number + " from " + source + "-->" + dest);
            TowerofHanoi(number - 1, temp, source, dest);
        }
    }
}
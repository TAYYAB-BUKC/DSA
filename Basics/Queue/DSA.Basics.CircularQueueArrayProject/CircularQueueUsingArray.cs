namespace DSA.Basics.CircularQueueArrayProject
{
	public class CircularQueueUsingArray
	{
		private int[] queueArray;
		private int front;
		private int rear;

		public CircularQueueUsingArray()
		{
			queueArray = new int[10];
			front = -1;
			rear = -1;
		}

		public CircularQueueUsingArray(int maxSize)
		{
			queueArray = new int[maxSize];
			front = -1;
			rear = -1;
		}
	}
}
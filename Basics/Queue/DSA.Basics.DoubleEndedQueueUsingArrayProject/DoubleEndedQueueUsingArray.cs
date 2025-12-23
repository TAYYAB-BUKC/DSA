namespace DSA.Basics.DoubleEndedQueueUsingArrayProject
{
	public class DoubleEndedQueueUsingArray
	{
		private int[] queueArray;
		private int front;
		private int rear;

		public DoubleEndedQueueUsingArray()
		{
			queueArray = new int[10];
			front = -1;
			rear = -1;
		}

		public DoubleEndedQueueUsingArray(int maxSize)
		{
			queueArray = new int[maxSize];
			front = -1;
			rear = -1;
		}
	}
}
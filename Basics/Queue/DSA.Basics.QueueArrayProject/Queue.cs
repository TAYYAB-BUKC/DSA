namespace DSA.Basics.QueueArrayProject
{
	public class Queue
	{
		private int[] queueArray;
		private int front;
		private int rear;

		public Queue()
		{
			queueArray = new int[10];
			front = -1;
			rear = -1;
		}

		public Queue(int size)
		{
			queueArray = new int[size];
			front = -1;
			rear = -1;
		}

		public bool IsEmpty()
		{
			return (front == -1 || front == rear + 1);
		}

		public bool IsFull()
		{
			return (rear == queueArray.Length - 1);
		}
	}
}
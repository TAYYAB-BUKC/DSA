namespace DSA.Basics.QueueArrayProject
{
	public class QueueUsingArray
	{
		private int[] queueArray;
		private int front;
		private int rear;

		public QueueUsingArray()
		{
			queueArray = new int[10];
			front = -1;
			rear = -1;
		}

		public QueueUsingArray(int size)
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

		public int Size()
		{
			if (IsEmpty())
				return 0;
			else
				return rear - front + 1;
		}

		public void Enqueue(int value)
		{
			if (IsFull())
			{
				Console.WriteLine("Queue is in overflow state");
				return;
			}
			if (front == -1)
				front = 0;
			rear++;
			queueArray[rear] = value;
		}

		public int Dequeue()
		{
			int value;
			if (IsEmpty())
			{
				Console.WriteLine("Queue is in underflow state");
				return -1;
			}

			value = queueArray[front];
			front = front + 1;
			return value;
		}

		public int Peek()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue is in underflow state");
				return -1;
			}
			return queueArray[front];
		}

		public void Display()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue is in underflow state");
				return;
			}

			Console.WriteLine("Queue is :\n\n");
			for (int index = front; index <= rear; index++)
				Console.Write($"{queueArray[index]}\t");

			Console.WriteLine();
		}
	}
}
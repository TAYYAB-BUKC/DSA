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

		public bool IsEmpty()
		{
			return front == -1;
		}

		public bool IsFull()
		{
			return (front == 0 && rear == queueArray.Length - 1) || front == rear + 1;
		}

		public int Size()
		{
			if (IsEmpty())
				return 0;

			if (IsFull())
				return queueArray.Length;

			int index = front;
			int size = 0;
			if (front <= rear)
			{
				while (index <= rear)
				{
					size++;
					index++;
				}
			}
			else
			{
				while (index <= queueArray.Length - 1)
				{
					size++;
					index++;
				}
				index = 0;
				while (index <= rear)
				{
					size++;
					index++;
				}
			}
			return size;
		}

		public void Enqueue(int info)
		{
			if (IsFull())
			{
				Console.WriteLine($"Queue is in overflow state");
				return;
			}
			if (front == -1)
				front = 0;

			if (rear == queueArray.Length - 1)
				rear = 0;
			else
				rear = rear + 1;
			queueArray[rear] = info;
		}

		public int Dequeue()
		{
			int value = queueArray[front];
			if (IsEmpty())
			{
				Console.WriteLine($"Queue is in underflow state");
				return -1;
			}

			if (front == rear)
			{
				front = -1;
				rear = -1;
			}
			else if (front == queueArray.Length - 1)
				front = 0;
			else
				front = front + 1;
			return value;
		}

		public int Peek()
		{
			if (IsEmpty())
			{
				Console.WriteLine($"Queue is in underflow state");
				return -1;
			}
			return queueArray[front];
		}
	}
}
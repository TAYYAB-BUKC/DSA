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

		public bool IsEmpty()
		{
			return front == -1;
		}

		public bool IsFull()
		{
			return (front == 0 && rear == queueArray.Length - 1) || (front == rear + 1);
		}

		public void Display()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue is in underflow state");
				return;
			}

			int index = front;
			Console.WriteLine("Queue is : ");
			if (front <= rear)
			{
				while (index <= rear)
				{
					Console.Write($"{queueArray[index++]}\t");
				}
			}
			else
			{
				while (index <= queueArray.Length - 1)
				{
					Console.Write($"{queueArray[index++]}\t");
				}
				index = 0;
				while (index <= rear)
				{
					Console.Write($"{queueArray[index++]}\t");
				}
			}

			Console.WriteLine();
		}

		public void InsertFront(int info)
		{
			if (IsFull())
			{
				Console.WriteLine("Queue is in overflow state");
				return;
			}

			if (front == -1)
			{
				front = 0;
				rear = 0;
			}
			else if (front == 0)
				front = queueArray.Length - 1;
			else
				front = front - 1;

			queueArray[front] = info;
		}

		public void InsertRear(int info)
		{
			if (IsFull())
			{
				Console.WriteLine("Queue is in overflow state");
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

		public int DeleteFront()
		{
			int info;
			if (IsEmpty())
			{
				Console.WriteLine("Queue is in underflow state");
				return -1;
			}

			info = queueArray[front];

			if (front == rear)
			{
				front = -1;
				rear = -1;
			}
			else if (front == queueArray.Length - 1)
				front = 0;
			else
				front = front + 1;
			
			return info;
		}
	}
}
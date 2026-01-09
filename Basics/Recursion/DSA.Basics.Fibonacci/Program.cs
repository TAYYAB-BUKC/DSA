using DSA.Basics.Fibonacci;

Console.WriteLine("Enter Number : ");
int terms = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= terms; i++)
    Console.Write(Fibonacci.CalculateFibonacciSeries(i) + " ");
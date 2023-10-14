using System;


Console.WriteLine("Enter the digit for diapasos of Fibonacci digit: ");
int digit = int.Parse(Console.ReadLine());

if (digit <= 0)
{
	Console.WriteLine("Please enter the positive digit!");
}
else
{
	int a = 0, b = 1;
	for (int i = 0; i < digit; i++)
	{
		Console.Write(a + " ");
		int tmp = a;
		a = b;
		b = tmp + b;
	}
	Console.WriteLine();
}
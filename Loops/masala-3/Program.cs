﻿Console.WriteLine("Enter the value of n: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += i;
}
Console.WriteLine(sum);
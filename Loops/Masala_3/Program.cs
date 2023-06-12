

using System.Diagnostics.Metrics;
int sum = 0, n;

Console.WriteLine("Enter the value of n:");
int n = Convert.Toint32(Console.ReadLine());

for (int i = 1; i <= n; i++)
    sum += i;

Console.WriteLine(sum);
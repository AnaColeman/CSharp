int a = 2;
int b = 10;

int max = a;

if (a > max) max = a;
if (b > max) max = b;

Console.Write("max -> ");
Console.WriteLine(max);

int min = a;

if (a < min) min = a;
if (b < min) min = b;

Console.Write("min -> ");
Console.WriteLine(min);
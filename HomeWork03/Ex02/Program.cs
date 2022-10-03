// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Enter the coordinates of the points: ");

Console.WriteLine("Enter X1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter C1: ");
int c1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter X2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter C2: ");
int c2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(c1 - c2, 2));

Console.WriteLine($"Distance -> {d:f2}");

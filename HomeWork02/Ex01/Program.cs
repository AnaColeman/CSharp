// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Enter three digit number: ");
int number=int.Parse(Console.ReadLine());
int result =(number/10)%10;
Console.Write("Second number -> ");
Console.WriteLine(result);

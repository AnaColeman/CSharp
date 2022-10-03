// Напишите программу, которая принимает на вход семь чисел, и находит их среднее арифметическое
// 1 2 3 4 5 6 7-> 4
// 10 20 30 40 50 60 70 -> 40

Console.Clear();
int[] array = {10, 20, 30, 40, 50, 60, 70};
int n = array.Length;
n = 7;
int index = 0;
int sum = 0;

while(index < n)
{
    sum = array[index] + sum;
    index++;
}
int mean = sum / n;

Console.Write("Arithmetical mean: ");
Console.WriteLine(mean);
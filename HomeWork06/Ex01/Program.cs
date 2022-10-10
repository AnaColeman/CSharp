// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Enter M numbers from the keyboard: "); 
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("User entered from keyboard: "); 
int []array = new int[M];
FillArray(array);
FindPositiveNumber(array);

void FillArray (int[]array)
{
    for (int i=0; i < M; i++)
    {
        array[i]=new Random().Next(-10,11);
        Console.Write(array[i]+ ", ");
    }
Console.WriteLine();
}

void FindPositiveNumber(int[]array)
{
    int count = 0;
    for (int j = 0; j < M; j++)
    {
        if (array [j] >= 0)
        count++; 
    }
    Console.WriteLine($"{count} numbers -> positive (that is > 0) ");
}
Console.WriteLine();
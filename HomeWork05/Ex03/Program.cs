// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] arrayInputDouble()
{
    Console.WriteLine("Enter the number of array elements:  ");
    int count = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[count];
	for(int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(-100, 101); 
	}
    return array;
}

void arrayOutput(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double diffMinMaxCount(double[] array) 
{
    double minElem = array[0];
    double maxElem = array[0];
    for(int i = 1; i < array.Length; i++)
	{
		if(array[i] < minElem)
        {
            minElem = array[i];
        }
        else if(array[i] > maxElem)
        {
            maxElem = array[i];
        }
	}
    Console.WriteLine($"Max element -> {maxElem} ");
    Console.WriteLine($"Min element -> {minElem} ");
    double diff = maxElem - minElem;
    return diff;
}

double[] array = arrayInputDouble();
arrayOutput(array); 
Console.WriteLine($"The difference between max and min array element: {diffMinMaxCount(array)} ");
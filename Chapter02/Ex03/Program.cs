int[] array = { 1, 2, 3, 4, 5, 4, 65, 3, 98 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1
    index++;
}
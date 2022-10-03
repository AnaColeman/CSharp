Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine());
int i = 1;

while(i <= N)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
i++;
}
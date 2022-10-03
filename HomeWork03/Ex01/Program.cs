// БЛАГОДАРЮ ЗА КОММЕНТАРИИ К ПРЕДЫДУЩИМ ДОМАШНИМ РАБОТАМ! :)

// Напишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter a five-digit number: "); 
string? num = Console.ReadLine(); 

void NumCheck(string num)
{
    if (num[0] == num[4] || num [1] == num [3])
    {
        Console.WriteLine($"{num} -> a palindrome");
    }
    else Console.WriteLine($"{num} -> not a palindrome.");
}

if (num!.Length == 5) 
{
    NumCheck(num);
}
else Console.WriteLine("You entered a non-five-digit number.");

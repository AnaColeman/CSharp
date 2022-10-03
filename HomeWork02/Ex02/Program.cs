// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();
Console.Write("Enter number: ");
string number=Console.ReadLine();

if (number.Length < 3)
{
    Console.WriteLine("-> third digit is not available"); 
}
else 
{
    char rezult=number[2];
    Console.Write("The third digit -> ");
    Console.WriteLine(rezult);
}
// прокомментируйте, пожалуйста, один момент: когда я меняю знак "<" на ">" результат в терминале не меняется. Почему?
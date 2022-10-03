// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Enter the number of the week day: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("It's weekend");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("It's not a day of the week");
  }
  else Console.WriteLine("It's a working day");
}

CheckingTheDayOfTheWeek(dayNumber);
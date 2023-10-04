/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int originalNumber = number;
if (number < 100)
{
    Console.WriteLine($"{originalNumber} -> третьей цифры нет");
}
else if (number < 1000)
{
    int thirdDigit = number % 10;
    Console.WriteLine($"{originalNumber} -> {thirdDigit}");
}
else
{
    while (number >= 1000)
    {
        number /= 10;
    }
    int thirdDigit = number % 10;   
    Console.WriteLine($"{originalNumber} -> {thirdDigit}");
}




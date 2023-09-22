// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

/* Вариант 1
Console.WriteLine("Введите первое число: ");
int nomer = Convert.ToInt32(Console.ReadLine());
if (nomer < 1||nomer > 7)
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
    if (nomer == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if (nomer == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (nomer == 3)
    {
        Console.WriteLine("Среда");
    }
    if (nomer == 4)
    {
        Console.WriteLine("Четверг");
    }
    if (nomer == 5)
    {
        Console.WriteLine("Пятница");
    }
    if (nomer == 6)
    {
        Console.WriteLine("Суббота");
    }
    if (nomer == 7)
    {
        Console.WriteLine("Воскресенье");
    }
}
*/

//Вариант 2

Console.WriteLine("Введите первое число: ");
int nomer = Convert.ToInt32(Console.ReadLine());
switch (nomer)
{
    case 1:
    {
        Console.WriteLine("Понедельник");
        break;
    }
    case 2:
    {
        Console.WriteLine("Вторник");
        break;
    }
    case 3:
    {
        Console.WriteLine("Среда");
        break;
    }
    case 4:
    {
        Console.WriteLine("Четверг");
        break;
    }
    case 5:
    {
        Console.WriteLine("Пятница");
        break;
    }
    case 6:
    {
        Console.WriteLine("Суббота");
        break;
    }
    case 7:
    {
        Console.WriteLine("Воскресенье");
        break;
    }
    default:
    {
        Console.WriteLine("Нет такого дня недели");
        break;
    }
}
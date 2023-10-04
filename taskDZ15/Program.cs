/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число: ");
int nomer = Convert.ToInt32(Console.ReadLine());
if (nomer < 1||nomer > 7)
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
    if (nomer == 1)
    {
        Console.WriteLine($"{nomer} -> Нет");
    }
    if (nomer == 2)
    {
        Console.WriteLine($"{nomer} -> Нет");
    }
    if (nomer == 3)
    {
        Console.WriteLine($"{nomer} -> Нет");
    }
    if (nomer == 4)
    {
        Console.WriteLine($"{nomer} -> Нет");
    }
    if (nomer == 5)
    {
        Console.WriteLine($"{nomer} -> Нет");
    }
    if (nomer == 6)
    {
        Console.WriteLine($"{nomer} -> Да");
    }
    if (nomer == 7)
    {
        Console.WriteLine($"{nomer} -> Да");
    }
}
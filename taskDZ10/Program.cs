// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 1000 && N > 99)
{
    int ost = N / 10;
    int ost2 = ost % 10;
    Console.WriteLine(ost2);
}
else
{
    Console.WriteLine("Введите трехзначное число");
}


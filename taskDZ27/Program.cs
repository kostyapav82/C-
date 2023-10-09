// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
        string numberStr = Console.ReadLine();

        int digitSum = 0;

        foreach (char digitChar in numberStr)
        {
            if (char.IsDigit(digitChar))
            {
                digitSum += int.Parse(digitChar.ToString());
            }
        }

        Console.WriteLine($"{numberStr} -> {digitSum}");
    
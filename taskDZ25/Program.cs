// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

 Console.Write("Введите число A: ");
        double A = double.Parse(Console.ReadLine());

        Console.Write("Введите число B: ");
        int B = int.Parse(Console.ReadLine());

        double result = 1;

        if (B < 0)
        {
            Console.WriteLine("B должно быть натуральным числом.");
        }
        else
        {
            for (int i = 0; i < B; i++)
            {
                result *= A;
            }

            Console.WriteLine($"{A}, {B} -> {result}");
        }
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
int negativeNumber = -number; // number = 4, а negnumber = -4 => диапазон хода [-4,4]
while (negativeNumber <= number)
{
Console.Write(negativeNumber + ", "); // == Console.Write($"{negativeNumber}, ") // -4 -3 -2 -1 0 1 2 3 4
negativeNumber++; // == negativeNumber = negativeNumber + 1; - negnum = -3
}
}
else
{
Console.WriteLine("Введите положительное число!");
}



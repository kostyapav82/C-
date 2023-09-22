Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int began = 1; 
while(began <= number)
{
    if(began%2 == 0)
{
Console.Write(began + ", ");
}
began++;
}

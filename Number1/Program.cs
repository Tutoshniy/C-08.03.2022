void ShowNumbers(int a, int b)
{
    while (a <= b)
    {
        Console.Write(" ");
        Console.Write(a);
        a++;
    }
}

Console.WriteLine("Введите Начальное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Конечное число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат: ");
ShowNumbers(a, b);
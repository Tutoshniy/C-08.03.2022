void Proverka(int a, int b)
{
    if (a*a == b || b*b == a)
    {
        if (a*a == b) Console.WriteLine("Первое число является квадратом второго");
        if (b*b == a) Console.WriteLine("Второе число является квадратом первого");
    }
    else Console.WriteLine("Ни первое число не является квадратом второго, ни наоборот");
}
Console.WriteLine("Введите первое число:");
int First = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int Second = Convert.ToInt32(Console.ReadLine());
Proverka(First, Second);
void Day(int date)
{
    if (date == 6 ||date == 7)
    {
        Console.WriteLine("Сегодня выходной. Можешь отдыхать.");
    }
    else
    {
        Console.WriteLine("Сегодня будни. Пора работать.");
    }
}

Console.WriteLine("Введите число дня недели: ");
int Today = Convert.ToInt32(Console.ReadLine());
Day(Today);
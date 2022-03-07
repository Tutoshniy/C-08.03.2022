void ChetOrNechet (int Last)
{
    int CurrentNumber = 1;
    while (CurrentNumber <= Last)
    {
        if (CurrentNumber % 2 == 0)
        {
            Console.Write(" ");
            Console.Write(CurrentNumber);
        }
        CurrentNumber++;
    }
}

Console.WriteLine("Введите конечное число: ");
int End = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Найдены Чётные числа: ");
ChetOrNechet(End);
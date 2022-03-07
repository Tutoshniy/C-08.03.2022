void Opredelenie(int X, int Y)
{
    if (X > 0 && Y > 0) Console.WriteLine("Точка находится в первой координатной плоскости");
    if (X < 0 && Y > 0) Console.WriteLine("Точка находится во второй координатной плоскости");
    if (X < 0 && Y < 0) Console.WriteLine("Точка находится в третьей координатной плоскости");
    if (X > 0 && Y < 0) Console.WriteLine("Точка находится в четвёртой координатной плоскости");
}
Console.WriteLine("Введите координату точки по оси абсцисс/X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки по оси ординат/Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Opredelenie(x, y);
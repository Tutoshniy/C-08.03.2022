double Distance2D(double X1, double Y1, double X2, double Y2)
{
    return Math.Sqrt(((X2 - X1) * (X2 - X1)) + ((Y2 - Y1) * (Y2 - Y1)));
}

Console.WriteLine("Введите координаты первой точки (X и Y)");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки (X и Y)");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Расстояние между точками - ");
double res = Distance2D(x1, y1, x2, y2);
Console.WriteLine(res);
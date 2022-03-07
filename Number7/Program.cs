double Distance2D(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    return Math.Sqrt(((X2 - X1) * (X2 - X1)) + ((Y2 - Y1) * (Y2 - Y1)) + ((Z2 - Z1) * (Z2 - Z1)));
}

Console.WriteLine("Введите координаты первой точки (X, Y и Z)");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки (X, Y и Z)");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Расстояние между точками - ");
double res = Distance2D(x1, y1, z1, x2, y2, z2);
Console.WriteLine(res);
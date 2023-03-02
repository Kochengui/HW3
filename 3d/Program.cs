int prostranstvo(string groove, string slowly)
{
    int x1 = prostranstvo("x", "A");
    int y1 = prostranstvo("y", "A");
    int z1 = prostranstvo("z", "A");
    int x2 = prostranstvo("x", "B");
    int y2 = prostranstvo("y", "B");
    int z2 = prostranstvo("z", "B");

    Console.Write($"Введите координату {groove} точки {slowly}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Scripe(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

double LengthOf3D = Math.Round(Scripe(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Растояние 3D отрезка  {LengthOf3D}");


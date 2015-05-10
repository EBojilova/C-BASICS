using System;

class Polygon
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        Point[] polygon = new Point[n];
        for (int i = 0; i < n; i++)
        {
            Point point = new Point();
            string[] input = Console.ReadLine().Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            point.X = int.Parse(input[0]);
            point.Y = int.Parse(input[1]);
            polygon[i] = point;
        }
        Console.WriteLine("perimeter = {0}", Math.Round((Geometry.CalcPerimeter(polygon)),2));
        Console.WriteLine("area = {0}", Math.Round((Geometry.CalcArea(polygon)), 2));
    }
}

// for (int i = 0; i < polygon.Length; i++)
//{
//Console.WriteLine("Point(" + polygon[i].X + ", " + polygon[i].Y + ")");
//}

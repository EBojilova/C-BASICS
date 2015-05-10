using System;

public static class Geometry
{
    public static double CalcArea(Point[] polygon)
    {
        double area = 0;
        for (int i = 0; i < polygon.Length - 1; i++)
        {
            area += polygon[i].X* polygon[i+1].Y- polygon[i + 1].X* polygon[i].Y;
        }
        area = Math.Abs(area)/2;
        return area;
    }
    
    public static double CalcPerimeter(Point[] polygon)
    {
        double perimeter = 0;
        for (int i = 0; i < polygon.Length - 1; i++)
        {
            perimeter += CalcDictance(polygon[i].X, polygon[i].Y, polygon[i + 1].X, polygon[i + 1].Y);
        }
        perimeter += CalcDictance(polygon[0].X, polygon[0].Y, polygon[polygon.Length - 1].X, polygon[polygon.Length - 1].Y);
        return perimeter;
    }

    public static double CalcDictance(int x1, int y1, int x2, int y2)
    {
        int dx = x2 - x1;
        int dy = y2 - y1;
        double distance = Math.Sqrt(dx * dx + dy * dy);
        return distance;
    }
}


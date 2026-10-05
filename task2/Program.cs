using System.Net.NetworkInformation;

class Circle
{
    static void Main()
    {
        const double Pi = 3.14;
        int radius = 4;
        // Pi = 3.17; // cannot change a constant
        Area(Pi, radius);
        Perimeter(Pi, radius);
    }
    static void Area(double Pi, int radius)
    {
        double area = Pi*radius*radius;
        Console.WriteLine(area);
    }
    static void Perimeter(double Pi, int radius)
    {
        double perimeter =  2*Pi*radius;
        Console.WriteLine(perimeter);
    }
}
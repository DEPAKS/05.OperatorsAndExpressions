using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double heigh = double.Parse(Console.ReadLine());
        double perimeter = 2*(width + heigh);
        double area = width * heigh;

        Console.WriteLine("Rectangle width: " + "{0}" + Environment.NewLine + "Rectangle heigh: " + "{1}" + Environment.NewLine, width, heigh);
        Console.WriteLine("Rectangle perimeter: " + "{0}" + Environment.NewLine + "Rectangle area: " + "{1}" + Environment.NewLine, perimeter, area);
    }
}

//Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
// | width | height | perimeter | area |
// |     3 |      4	|        14	|   12 |
// |   2.5 |      3	|        11	|  7.5 |
// |     5 |      5	|        20	|   25 |
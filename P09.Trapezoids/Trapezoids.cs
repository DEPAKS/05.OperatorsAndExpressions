using System;

class Trapezoids
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = ((sideA + sideB) / 2) * height;
        Console.WriteLine("Side a = " + "{0}" + Environment.NewLine + "Side b = " + "{1}" + Environment.NewLine + "Height is: " + "{2}" + Environment.NewLine + "Area is: " + "{3}", sideA, sideB, height, area);
    }
}

//Write an expression that calculates trapezoid's area by given sides a and b and height h. Examples:
// |     a |     b |     h | 	  area |	 
// |     5 |     7 |    12 |        72 |	
// |     2 |     1 |    33 |      49.5 |	
// |   8.5 |   4.3 |   2.7 |     17.28 |	
// |   100 |   200 |   300 |     45000 |	
// | 0.222 | 0.333 | 0.555 | 0.1540125 |
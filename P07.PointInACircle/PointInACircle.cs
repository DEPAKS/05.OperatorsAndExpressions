using System;

class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (((x * x) + (y * y)) <= 2 * 2);   //сборът на x на квадрат и у на квадрат трябва да е по-малък или равен на радиуса на квадрат (стойността на радиуса е подадена в заданието); важи за окръжност със съответните координати: K({0, 0}, 2);
        Console.WriteLine(isInCircle);
    }
}

]
//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:
// |    x |	    y |	inside |	 
// |    0 |	    1 |	true   |
// |   -2 |	    0 |	true   |
// |   -1 |     2 |	false  |
// |  1.5 |	   -1 |	true   |
// | -1.5 |	 -1.5 |	false  |
// |  100 |	  -30 |	false  |
// |    0 |	    0 |	true   |
// |  0.2 |	 -0.8 |	true   |
// |  0.9 |	-1.93 |	false  |
// |    1 | 1.655 |	true   | 
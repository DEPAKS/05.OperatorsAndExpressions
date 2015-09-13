using System;

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). Examples:
// |    x |	   y | inside K & outside of R |	 
// |    1 |	   2 | yes	                   |
// |  2.5 |	   2 | no	                   |
// |    0 |	   1 | no	                   |
// |  2.5 |	   1 | no	                   |
// |    2 |	   0 | no	                   |
// |    4 |	   0 | no	                   |
// |  2.5 |  1.5 | no	                   |
// |    2 |  1.5 | yes	                   |
// |    1 |  2.5 | yes	                   |
// | -100 |	-100 | no	                   |

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        //(x - center_x)^2 + (y - center_y)^2 < radius^2
        bool isInCircle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= 1.5 * 1.5; //търсим кога ще е в окръжността. В дадената формула са важни да се вземат под внимание координатите в заданието: K({1, 1}, 1.5).
        bool isInRectangle = (x <= 5 &&  x >= -1) && (y >= -1 && y <= 1); //търсим кога ще е в правочгълника, съответно х и у м/у кои стойностти на координатната система трябва да се намират, за да са вътре в правоъгълника.

        if (isInCircle && !isInRectangle) //ако е в окръжността и извън(!) правоъгълника.
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 
   //Equation of Circle: (Cartesian coordinates)
   //for a circle with center (j, k) and radius (r):
  //  (x-j)^2 + (y-k)^2 = r^2
using System;

class OddOrEven
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        bool isOdd = a % 2 > 0 || a % 2 < 0;   //второто условие покрива и отрицателните числа, които са дадени, като изискуеми в примера в задачата.
        Console.WriteLine(isOdd);
    }
}

//Write an expression that checks if given integer is odd or even.
// |  n	|  Odd? |
// |  3	|  true |
// |  2	| false |
// | -2	| false |
// | -1	|  true |
// |  0	| false |  
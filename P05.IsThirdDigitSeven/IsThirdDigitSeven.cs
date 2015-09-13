using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        int num = Math.Abs(int.Parse(Console.ReadLine())); //Math.Abs returns the absolute value of the integer.
        bool isSeven = (num / 100) % 10 == 7;
        Console.WriteLine(isSeven);
    }
}

//Write an expression that checks for given integer if its third digit from right-to-left is 7. Examples:
// |       n | Third digit 7? |
// |       5 |          false |
// |     701 |	         true |
// |    9703 |           true |
// |     877 |          false |
// |  777877 |          false |
// | 9999799 |           true |
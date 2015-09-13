﻿using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int devidedNum = int.Parse(Console.ReadLine());
        bool result = devidedNum % 5 == 0 && devidedNum % 7 == 0;
        Console.WriteLine(result);
    }
}

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:
// |   n | Divided by 7 and 5? |
// |   3 |               false |
// |   0 |               false |
// |   5 |               false |
// |   7 |               false |
// |  35 |                true |
// | 140 |                true |
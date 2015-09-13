using System;

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. Examples:
//n	      binary representation of n	p	bit @ p == 1
//5	       00000000 00000101	        2	true
//0        00000000 00000000	        9	false
//15	   00000000 00001111	        1	true
//5343	   00010100 11011111	        7	true
//62241	   11110011 00100001	       11	false


class CheckABitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine((n & (1 << p)) > 0 ? true : false);//(1<<p) замества маската. Аналогично е, да се напише: маска = 1 << р и после на мястото на (1<<р) да запиша mask.
    }
}


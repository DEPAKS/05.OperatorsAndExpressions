using System;

class FourDigitsNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = n % 10; //вземаме последнота цифра от 4-ри-цифреното цяло число (единиците).
        int c = (n / 10) % 10; //вземаме предпоследнота цифра от 4-ри-цифреното цяло число (десетиците).
        int b = (n / 100) % 10; //вземаме цифрата представяща стотиците от 4-ри-цифреното цяло число.
        int a = (n / 1000) % 10; //вземаме цифрата представяща хилядните от 4-ри-цифреното цяло число.
        int sum = a + b + c + d;
        Console.WriteLine(sum);
        Console.WriteLine("{0}{1}{2}{3}",d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. Examples:
// |      |               |          | last digit | second and third |
// |    n | sum of digits |	reversed |   in front |	digits exchanged |
// | 2011 |             4 |     1102 |	     1201 |	            2101 |
// | 3333 |            12 |     3333 |	     3333 |             3333 |
// | 9876 |            30 |     6789 |	     6987 |	            9786 |
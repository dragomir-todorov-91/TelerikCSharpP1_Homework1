//Create a console application that calculates and prints the square of the number 12345.

using System;

class SquareOf12345
{
    static void Main()
    {
        System.Console.WriteLine(12345 * 12345); // Direct multiplication

        int num = 12345;
        System.Console.WriteLine( Math.Pow(num , 2) ); // Using the pow() method
    }
}

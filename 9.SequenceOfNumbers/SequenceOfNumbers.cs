//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class SequenceOfNumbers
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if(i%2 == 0)
                Console.Write( i );
            else
                Console.Write( 0 - i );
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

//Create a console application that prints the current date and time.

using System;

class DateTime
{
    static void Main()
    {
        System.Console.WriteLine(System.DateTime.Now.Date.ToShortDateString());
        System.Console.WriteLine(System.DateTime.Now.ToString("HH:mm:ss"));
    }
}

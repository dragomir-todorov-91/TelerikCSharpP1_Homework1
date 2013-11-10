using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Write your age: "); //Изписва текст, подканящ потребителя да въведе възраста си, като не преминава на нова линия
        string line = Console.ReadLine(); //При вход и натискане на бутона Enter информацията се съхранява в стринг line
        int age = 0; // int променлива, която ще съхрани възраста на потребителя
        if (line != null)
            age = int.Parse(line); //Преобразуваме string-a в int променлива

        Console.WriteLine("Your age after 10 years is {0}!",age+10);
    }
}

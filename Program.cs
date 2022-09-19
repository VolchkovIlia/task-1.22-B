using System;
public class Mainclass
{
    public static void Main()
    {
        int x, a;
        Console.WriteLine("Введите Х:");
        a = int.Parse(Console.ReadLine());
        x = 12 * a * a + 7 * a - 16;
        Console.WriteLine("Значение функции {0}", x);
    }
}
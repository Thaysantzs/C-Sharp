using System;
namespace Ourcompany;

public class Library
{
    public static int ReadInterge(string prompt = "Number", string signal = "=")
    {
        Console.Write($"{prompt}{signal} ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void RepeatChar(int times, string content)
    {
        for (int i = 1; i <= times; i++)
        {
            Console.Write(content);
        }
    }

    public static void IntDivision(int dividend, int divisor, out int quocient, out int remainder)
    {
        quocient = dividend / divisor;
        remainder = dividend % divisor;
    }
}
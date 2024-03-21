using System;
class Program
{
    static int Ackerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackerman(m - 1, 1);
        }
        else
        {
            return Ackerman(m - 1, Ackerman(m, n - 1));
        }
    }

    static void Main()
    {
        Console.Write("Значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = Ackerman(m, n);
        Console.WriteLine($"Значение функции Аккермана для чисел {m} и {n} равна {result}");
    }
}
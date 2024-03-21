{
    {
        PrintNaturalNumbers(1, 9);
    }
    static void
    PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
     {
       Console.WriteLine(m);
       PrintNaturalNumbers(m + 1, n);
     }
    }
}

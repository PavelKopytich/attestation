using System;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        
        PrintArrayFromEnd(arr, arr.Length - 1);
    }

    static void PrintArrayFromEnd(int[] arr, int idx)
    {
        if (idx < 0)
        {
            return;
        }
        
        Console.WriteLine(arr[idx]);
        PrintArrayFromEnd(arr, idx - 1);
    }
}
using System;

class Program
{

    static void spaceCounter(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == ' ')
            {
                count++;
            }
        }
        Console.WriteLine("This string contains {0} spaces!", count);
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Please input a string:");
        string str = Console.ReadLine();
        spaceCounter(str);
    }
}
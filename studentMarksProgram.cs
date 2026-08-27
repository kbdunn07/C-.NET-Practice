/*
internal class studentMarkProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many students are in your course?");
        string tempnum = Console.ReadLine();
        int studentnum = Convert.ToInt32(tempnum);
        decimal[] studentMarks = new decimal[studentnum];
        Console.WriteLine("\nPlease Enter each Student Mark:");
        for (int i = 0; i < studentMarks.Length; i++)
        {
            string tempmark = Console.ReadLine();
            studentMarks[i] = Convert.ToDecimal(tempmark);
        }

        Console.WriteLine("\nThere are {0} students within this course.", studentnum);
        Console.WriteLine("Each of their Marks are as follows:");
        foreach (decimal m in studentMarks)
        {
            Console.WriteLine(m + "%");
        }
        Console.WriteLine("\nThe Highest Mark in the course is {0}%, while the lowest is {1}%.", studentMarks.Max(), studentMarks.Min());

    }
}
*/
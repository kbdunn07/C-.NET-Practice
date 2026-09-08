using System;
using System.Linq;


public class StudentGradeCalculator
{

    static void Part1() 
        {
            Console.WriteLine ("Enter your First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your Age:");
            string age = Console.ReadLine();
            Console.WriteLine("Enter your Major:");
            string major = Console.ReadLine();

            Console.WriteLine($"\nStudent Information\n----------\nName: {firstName} {lastName}\nAge: {age}\nMajor: {major}");
        }

    static void Part2and3and4()
        {
            int[] grades = new int[5];
            Console.WriteLine("Enter Grade 1:");
            int grade = Convert.ToInt32(Console.ReadLine());
            grades[0] = grade;
            Console.WriteLine("Enter Grade 2:");
            grade = Convert.ToInt32(Console.ReadLine());
            grades[1] = grade;
            Console.WriteLine("Enter Grade 3:");
            grade = Convert.ToInt32(Console.ReadLine());
            grades[2] = grade;
            Console.WriteLine("Enter Grade 4:");
            grade = Convert.ToInt32(Console.ReadLine());
            grades[3] = grade;
            Console.WriteLine("Enter Grade 5:");
            grade = Convert.ToInt32(Console.ReadLine());
            grades[4] = grade;

            int total =0;
            foreach (int g in grades) 
            {
                total+=g;
            }

            double avg = total / 5.0;
            Console.WriteLine($"Grade Summary\n--------\nTotal: {total}\nAverage: {avg}\nHighest Grade: {grades.Max()}\nLowest Grade: {grades.Min()}");
            string letter;
            if (avg >= 90)
            {
                letter = "A";
            }
            else if (avg < 90 && avg >= 80)
            {
                letter = "B";
            }
            else if (avg < 80 && avg >= 70)
            {
                letter = "C";
            }
            else if (avg < 70 && avg >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
            string status;
            if (avg >= 60)
            {
                status = "Passed";
            } else {
                status = "Failed";                
            }
            Console.WriteLine($"Letter Grade: {letter}");
            Console.WriteLine($"Status: {status}");

        }



    
    public static void Main(string[] args)
    {
        //Part1();
        Part2and3and4();
        
        
    }
}

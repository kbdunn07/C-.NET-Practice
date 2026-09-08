using System;
using System.Linq;

class StudentGradeCalculator
{
    
    static double CalculateAverage(double[] grades) {
        double total = 0;
        foreach (double g in grades) {
            total+=g;
        }
        return (total / 5.0);
    }

    static double FindHighest(double[] grades) {
        return grades.Max();
    }

    static double FindLowest(double[] grades) {
        return grades.Min();
    }
    
    static char CalculateLetterGrade(double avg) {
        char letter;
            if (avg >= 90)
            {
                letter = 'A';
            }
            else if (avg < 90 && avg >= 80)
            {
                letter = 'B';
            }
            else if (avg < 80 && avg >= 70)
            {
                letter = 'C';
            }
            else if (avg < 70 && avg >= 60)
            {
                letter = 'D';
            }
            else
            {
                letter = 'F';
            }
        return letter;
    }

    
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        string age = Console.ReadLine();
        Console.WriteLine("Enter your major:");
        string major = Console.ReadLine();

        Console.WriteLine("\nStudent Information\n----------");
        Console.WriteLine($"Name: {firstName} {lastName}\nAge: {age}\nMajor: {major}");

        double[] grades = new double[5];

        Console.WriteLine("\nEnter Grade 1:");
        double grade = Convert.ToDouble(Console.ReadLine());
        
        while (grade < 0 || grade > 100) {
            Console.WriteLine("Invalid grade: Please enter a value between 0 and 100.");
            grade = Convert.ToDouble(Console.ReadLine());
        }
        
        grades[0] = grade;
        
        
        Console.WriteLine("Enter Grade 2:");
        grade = Convert.ToDouble(Console.ReadLine());
        
        while (grade < 0 || grade > 100) {
            Console.WriteLine("Invalid grade: Please enter a value between 0 and 100.");
            grade = Convert.ToDouble(Console.ReadLine());
        }
        
        grades[1] = grade;
        
        
        Console.WriteLine("Enter Grade 3:");
        grade = Convert.ToDouble(Console.ReadLine());
        
        while (grade < 0 || grade > 100) {
            Console.WriteLine("Invalid grade: Please enter a value between 0 and 100.");
            grade = Convert.ToDouble(Console.ReadLine());
        }
        
        grades[2] = grade;
        
        
        Console.WriteLine("Enter Grade 4:");
        grade = Convert.ToDouble(Console.ReadLine());
        
        while (grade < 0 || grade > 100) {
            Console.WriteLine("Invalid grade: Please enter a value between 0 and 100.");
            grade = Convert.ToDouble(Console.ReadLine());
        }
        
        grades[3] = grade;
        
        
        Console.WriteLine("Enter Grade 5:");
        grade = Convert.ToDouble(Console.ReadLine());
        
        while (grade < 0 || grade > 100) {
            Console.WriteLine("Invalid grade: Please enter a value between 0 and 100.");
            grade = Convert.ToDouble(Console.ReadLine());
        }
        
        grades[4] = grade;

        double total = 0;
        foreach (double g in grades) {
            total+=g;
        }

        Console.WriteLine("\nGrade Summary\n----------");
        Console.WriteLine($"Total: {total}\nAverage: {CalculateAverage(grades)}\nHighest Grade: {FindHighest(grades)}\nLowest Grade: {FindLowest(grades)}\n\nFinal Letter Grade: {CalculateLetterGrade(CalculateAverage(grades))}");
        string status;
        if (CalculateAverage(grades) >= 60) {
            status = "Passed";
        } else {
            status = "Failed";
        }
        Console.WriteLine("Status: " + status);
        Console.WriteLine("\nThank you for using the Student Grade Calculator!");
    }
}














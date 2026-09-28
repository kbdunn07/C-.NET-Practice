using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    interface ICalorieCalculator
    {
        double CaloricCalculator();
        double CaloricCalculator(double bodyFatPercentage);
    }

    abstract class Person : ICalorieCalculator
    {
        public string firstName;
        public string lastName;
        public int age;
        public double weight;
        public double height;
        public int activityLevel;

        public Person(string firstName, string lastName, int age, double weight, double height, int activityLevel)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.weight = weight;
            this.height = height;
            this.activityLevel = activityLevel;
        }

        public abstract double CaloricCalculator();
        public abstract double CaloricCalculator(double bodyFatPercentage);
    }

    class MaleUser : Person
    {
        public MaleUser(string firstName, string lastName, int age, double weight, double height, int activityLevel)
            : base(firstName, lastName, age, weight, height, activityLevel)
        {
        }

        public override double CaloricCalculator()
        {
            double BMR = (10 * weight) + (6.25 * height) - (5 * age) + 5;
            double maintenance = 0.0;

            if (activityLevel == 1)
            {
                maintenance = BMR * 1.2;
            }
            else if (activityLevel == 2)
            {
                maintenance = BMR * 1.375;
            }
            else if (activityLevel == 3)
            {
                maintenance = BMR * 1.55;
            }
            else if (activityLevel == 4)
            {
                maintenance = BMR * 1.725;
            }
            else if (activityLevel == 5)
            {
                maintenance = BMR * 1.9;
            }
            else
            {
                Console.WriteLine("Invalid activity level.");
            }

            return maintenance;
        }

        public override double CaloricCalculator(double bodyFatPercentage)
        {
            double leanBodyMass = weight * (1 - bodyFatPercentage / 100);
            double BMR = (21.6 * leanBodyMass) + 370;
            double maintenance = 0.0;

            if (activityLevel == 1)
            {
                maintenance = BMR * 1.2;
            }
            else if (activityLevel == 2)
            {
                maintenance = BMR * 1.375;
            }
            else if (activityLevel == 3)
            {
                maintenance = BMR * 1.55;
            }
            else if (activityLevel == 4)
            {
                maintenance = BMR * 1.725;
            }
            else if (activityLevel == 5)
            {
                maintenance = BMR * 1.9;
            }
            else
            {
                Console.WriteLine("Invalid activity level.");
            }

            return maintenance;
        }
    }

    class FemaleUser : Person
    {
        public FemaleUser(string firstName, string lastName, int age, double weight, double height, int activityLevel)
            : base(firstName, lastName, age, weight, height, activityLevel)
        {
        }

        public override double CaloricCalculator()
        {
            double BMR = (10 * weight) + (6.25 * height) - (5 * age) - 161;
            double maintenance = 0.0;

            if (activityLevel == 1)
            {
                maintenance = BMR * 1.2;
            }
            else if (activityLevel == 2)
            {
                maintenance = BMR * 1.375;
            }
            else if (activityLevel == 3)
            {
                maintenance = BMR * 1.55;
            }
            else if (activityLevel == 4)
            {
                maintenance = BMR * 1.725;
            }
            else if (activityLevel == 5)
            {
                maintenance = BMR * 1.9;
            }
            else
            {
                Console.WriteLine("Invalid activity level.");
            }

            return maintenance;
        }

        public override double CaloricCalculator(double bodyFatPercentage)
        {
            double leanBodyMass = weight * (1 - bodyFatPercentage / 100);
            double BMR = (21.6 * leanBodyMass) + 370;
            double maintenance = 0.0;

            if (activityLevel == 1)
            {
                maintenance = BMR * 1.2;
            }
            else if (activityLevel == 2)
            {
                maintenance = BMR * 1.375;
            }
            else if (activityLevel == 3)
            {
                maintenance = BMR * 1.55;
            }
            else if (activityLevel == 4)
            {
                maintenance = BMR * 1.725;
            }
            else if (activityLevel == 5)
            {
                maintenance = BMR * 1.9;
            }
            else
            {
                Console.WriteLine("Invalid activity level.");
            }

            return maintenance;
        }
    }

    sealed class CalorieGoal
    {
        public string Name;
        public double AdjustmentPercentage;
        public CalorieGoal(string name, double adjustmentPercentage)
        {
            Name = name;
            AdjustmentPercentage = adjustmentPercentage;
        }

        public double CalculateCalories(double maintenanceCalories)
        {
            return maintenanceCalories * (1 + AdjustmentPercentage);
        }
    }

    delegate double CalorieCalculation();

    static void Main()
    {
        List<CalorieGoal> goals = new List<CalorieGoal> {new CalorieGoal("Extreme Weight Loss", -0.25), new CalorieGoal("Mild Weight Loss", -0.15), new CalorieGoal("Slight Weight Loss", -0.10), new CalorieGoal("Maintenance", 0.00), new CalorieGoal("Slight Weight Gain", 0.10), new CalorieGoal("Mild Weight Gain", 0.15), new CalorieGoal("Extreme Weight Gain", 0.25)};
        Person user = new MaleUser("John", "Doe", 25, 80, 180, 3);
        CalorieCalculation calculation = user.CaloricCalculator;
        double maintenanceCalories = calculation();
        string selectedGoal = "Slight Weight Loss";
        CalorieGoal goal = goals.First(g => g.Name == selectedGoal);
        double recommendedCalories = goal.CalculateCalories(maintenanceCalories);
        Console.WriteLine("Maintenance Calories: " + Math.Round(maintenanceCalories));
        Console.WriteLine("Goal: " + goal.Name);
        Console.WriteLine("Recommended Calories: " + Math.Round(recommendedCalories));
    }
}
```

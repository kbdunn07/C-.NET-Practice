using System;
using System.Linq;

class Program
{
    abstract class Person
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
}

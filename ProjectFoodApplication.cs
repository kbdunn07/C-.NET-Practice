using System;
using System.Linq;

class Program
{

    class User
    {
        public string firstName;
        public string lastName;
        public string gender;
        public int age;
        public double weight; //kgs
        public double height; //cm
        public int activityLevel; //1-5

        public User(string firstName, string lastName, string gender, int age, double weight, double height, int activityLevel)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.weight = weight;
            this.height = height;
            this.activityLevel = activityLevel;
        }

    }

    static double CaloricCalculator(User user)
    {
        double maintenance = 0.0;
        if (user.gender.Equals("Male") || user.gender.Equals("male"))
        {
            double BMR = (10 * user.weight) + (6.25 * user.height) - (5 * user.age) + 5;
            if (user.activityLevel == 1)
            {
                maintenance = BMR * 1.2;
            }
            else if (user.activityLevel == 2)
            {
                maintenance = BMR * 1.375;
            }
            else if (user.activityLevel == 3)
            {
                maintenance = BMR * 1.55;
            }
            else if (user.activityLevel == 4)
            {
                maintenance = BMR * 1.725;
            }
            else if (user.activityLevel == 5)
            {
                maintenance = BMR * 1.9;
            }
            else
            {
                Console.WriteLine("Invalid activity level.");
            }
        }
        else if (user.gender.Equals("Female") || user.gender.Equals("female"))
        {
            double BMR = (10 * user.weight) + (6.25 * user.height) - (5 * user.age) -161;
            if (user.activityLevel == 1)
            {
                maintenance = BMR * 1.2;
            }
            else if (user.activityLevel == 2)
            {
                maintenance = BMR * 1.375;
            }
            else if (user.activityLevel == 3)
            {
                maintenance = BMR * 1.55;
            }
            else if (user.activityLevel == 4)
            {
                maintenance = BMR * 1.725;
            }
            else if (user.activityLevel == 5)
            {
                maintenance = BMR * 1.9;
            }
            else
            {
                Console.WriteLine("Invalid activity level.");
            }
        }
        return maintenance;
    }
}

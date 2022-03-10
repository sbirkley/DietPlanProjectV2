using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace dietProjV2
{
    class Calculator
    {
        public int age;
        public double weight;
        public double height;
        public string gender;
        public double activityLevel;
        public double energyExpenditure;
        public double calTarget;
        public double weightKg;
        public double heightCm;

        string goalQuestion;

        double goalWeight;
        double calPlan;
        double deficit;
        double daysToOneLb;
        double lbsToLose;
        double daysToGoal;

        public void RunCalc()
        {
            Clear();
            WriteLine("What is your age? ");
            age = Convert.ToInt32(ReadLine());

            WriteLine("\nWhat is your weight? (lbs) ");
            weight = Convert.ToDouble(ReadLine());
            weightKg = weight * 0.454;
            
            WriteLine("\nWhat is your height (in)? ");
            height = Convert.ToDouble(ReadLine());
            heightCm = height * 2.54;

            WriteLine("\nWhat is your activity level?");
            WriteLine("  1) Sedentary\n  2) Lightly Active\n  3) Moderately Active\n  4) Very Active");
            activityLevel = Convert.ToInt32(ReadLine());

            switch (activityLevel)
            {
                case 1:
                    activityLevel = 1.2;
                    WriteLine(activityLevel);
                    break;
                case 2:
                    activityLevel = 1.375;
                    WriteLine(activityLevel);
                    break;
                case 3:
                    activityLevel = 1.55;
                    WriteLine(activityLevel);
                    break;
                case 4:
                    activityLevel = 1.725;
                    WriteLine(activityLevel);
                    break;
                default:
                    WriteLine("Please enter a valid response.\n\nPress any key to return . . .");
                    ReadKey(true);
                    RunCalc();
                    break;
            }

            WriteLine("\nDo you identify as Male or Female? (Select 'M' or 'F') ");
            gender = ReadLine();
            

            if (gender.Trim().ToLower() == "f")
            { 
                    double basalMetRate = (10 * weight) + (6.26 * height) - (5 * age) - 161;
                    double result = basalMetRate * activityLevel;
                    energyExpenditure = result;
            }
            else if (gender.Trim().ToLower() == "m")
            {
                double basalMetRate = (10 * weight) + (6.26 * height) - (5 * age) + 5;
                double result = basalMetRate * activityLevel;
                energyExpenditure = result;
            }
            else
            {
                WriteLine("Please enter a valid response.");
                WriteLine("Press any key to return . . .");
                ReadKey(true);
                RunCalc();
            }

            WriteLine("\n\nWhy do you want to try BRANDNAME?");
            WriteLine("\n  1) I want to lose weight.\n  2) I want to reset.\n  3) I'm too busy to sit down and eat.");
            int reply = Convert.ToInt32(ReadLine());

            if (reply == 1)
            {
                calTarget = ((energyExpenditure) - 300);
                calTarget = Math.Round(calTarget);
                
                if (calTarget < 1200)
                {
                    Clear();
                    WriteLine("Your calorie target is 1200 calories.");
                }
                else
                {
                    Clear();
                    WriteLine($"Your calorie target is {calTarget} calories.");
                }
            }

            else if (reply == 2 || reply == 3) 
            {
                calTarget = energyExpenditure;
                calTarget = Math.Round(calTarget);
                if (calTarget < 1200)
                {
                    Clear();
                    WriteLine("Your calorie target is 1200 calories.");
                }
                else
                {
                    Clear();
                    WriteLine($"Your calorie target is {calTarget} calories.");
                }
            }

            else 
            {
                WriteLine("Please enter a valid response.");
                WriteLine("Press any key to return . . . ");
                ReadKey(true);
                RunCalc();
            }
            if (calTarget <= 1599)
            {
                WriteLine("\nWe think your best match is our Lightyear Plan.\n\n");
                DietObj lightYearPlan = new DietObj("Lightyear Plan", 1250, 105);
                Menu goToMain = new Menu();
                goToMain.ReturnToMain();

                if (reply == 1)
                {
                    WriteLine("\n\nDo you want to see how long it will take to acheive your goal weight? (Y/N) ");
                    goalQuestion = ReadLine();

                    if (goalQuestion.Trim().ToLower() == "y")
                        WeightTimeCalc();
                    else
                    WriteLine("\n\nPress any key to return to the main menu . . . ");
                    ReadKey(true);
                    Menu goToMain2 = new Menu();
                    goToMain2.RunMenu();
                }
            }

            else if (calTarget > 1599 && calTarget <= 1799)
            {
                WriteLine("\nWe think your best match is our Nebula Plan.\n\n");
                DietObj nebulaPlan = new DietObj("Nebula Plan", 1600, 115);
                Menu goToMain2 = new Menu();
                goToMain2.ReturnToMain();
            }

            else if (calTarget > 1799 && calTarget <= 1999)
            {
                WriteLine("\nWe think your best match is our Supernova Plan.\n\n");
                DietObj supernovaPlan = new DietObj("Supernova Plan", 1800, 145);
                Menu goToMain2 = new Menu();
                goToMain2.ReturnToMain();
            }
            else
            {
                WriteLine("\nWe think your best match is our Helios Plan.\n\n");
                DietObj heliosPlan = new DietObj("Helios Plan", 2200, 155);
                Menu goToMain2 = new Menu();
                goToMain2.ReturnToMain();
            }
        }
        public void WeightTimeCalc()
        {
            Clear();
            WriteLine("\n\nWhat is your goal weight? ");
            goalWeight = Convert.ToDouble(ReadLine());
            WriteLine("\nHow many calories do you plan to eat each day?");
            calPlan = Convert.ToDouble(ReadLine());
            deficit = energyExpenditure - calPlan;

            daysToOneLb = 3500 / deficit;
            lbsToLose = weight - goalWeight;
            daysToGoal = lbsToLose * daysToOneLb;

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"\n\nWith a caloric deficit of {Math.Round(deficit)}, we project that it will take you approximately {Math.Round(daysToGoal)} days to reach your goal.");
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("\n\nPress any key to return to the main menu . . . ");

        }

    }

}

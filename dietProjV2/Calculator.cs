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
        public int weight;
        public double height;
        public char gender;
        public double activityLevel;
        public double energyExpenditure;
        public double calTarget;

        public void RunCalc()
        {
            Clear();
            WriteLine("What is your age? ");
            age = Convert.ToInt32(ReadLine());

            WriteLine("What is your weight? (kg) ");
            weight = Convert.ToInt32(ReadLine());

            WriteLine("What is your height (cm)? ");
            height = Convert.ToDouble(ReadLine());

            WriteLine("What is your activity level?");
            WriteLine("  1) Sedentary\n  2) Lightly Active\n  3) Moderately Active\n  4) Very Active");
            activityLevel = Convert.ToInt32(ReadLine());

            if (activityLevel == 1)
            {
                activityLevel = 1.2;
            }

            else if (activityLevel == 2)
            {
                activityLevel = 1.375;
            }

            else if (activityLevel == 3)
            {
                activityLevel = 1.55;
            }

            else if (activityLevel == 4)
            {
                activityLevel = 1.725;
            }
            else
            {
                WriteLine("Please enter a valid response.");
                WriteLine("Press any key to return . . . ");
                ReadKey(true);
                RunCalc();
            }
            WriteLine("Do you identify as Male or Female? (Select 'M' or 'F') ");
            gender = Convert.ToChar(ReadLine());
            //To Lower or To Upper

            if (gender == 'f')
            { 
                    double basalMetRate = (10 * weight) + (6.26 * height) - (5 * age) - 161;
                    double result = basalMetRate * activityLevel;
                    energyExpenditure = result;
                   // WriteLine($"Your TDEE is {energyExpenditure}.");
                
            }

            else if (gender == 'm')
            {
                double basalMetRate = (10 * weight) + (6.26 * height) - (5 * age);
                double result = basalMetRate * activityLevel;
                energyExpenditure = result;

                //WriteLine($"Your TDEE is {energyExpenditure}.");
            }

            else
            {
                WriteLine("Please enter a valid response.");
                WriteLine("Press any key to return . . .");
                ReadKey(true);
                RunCalc();
            }

            WriteLine("\nWhy do you want to try BRANDNAME?");
            WriteLine("\n  1) I want to lose weight.\n  2) I want to reset.\n  3) I'm too busy to sit down and eat.");
            int reply = Convert.ToInt32(ReadLine());

            if (reply == 1)
            {
                calTarget = ((energyExpenditure) - 300);

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
                WriteLine("\nWe think your best match is our Lightyear Plan.");
                DietObj lightYearPlan = new DietObj();
                lightYearPlan.Pick("Lightyear Plan", 1250, 105);
                WriteLine("\n\nPress any key to return to the main menu . . . ");
                ReadKey(true);
                Menu goToMain = new Menu();
                goToMain.RunMenu();
                
            }

            else if (calTarget > 1599 && calTarget <= 1799)
            {
                WriteLine("\nWe think your best match is our Nebula Plan.");
                DietObj nebulaPlan = new DietObj();
                nebulaPlan.Pick("Nebula Plan", 1600, 115);
                WriteLine("\n\nPress any key to return to the main menu . . . ");
                ReadKey(true);
                Menu goToMain = new Menu();
                goToMain.RunMenu();

            }

            else if (calTarget > 1799 && calTarget <= 1999)
            {
                WriteLine("\nWe think your best match is our Supernova Plan.");
                DietObj supernovaPlan = new DietObj();
                supernovaPlan.Pick("Supernova Plan", 1800, 145);
                WriteLine("\n\nPress any key to return to the main menu . . . ");
                ReadKey(true);
                Menu goToMain = new Menu();
                goToMain.RunMenu();

            }
            else
            {
                WriteLine("\nWe think your best match is our Helios Plan.");
                DietObj heliosPlan = new DietObj();
                heliosPlan.Pick("Helios Plan", 2200, 155);
                WriteLine("\n\nPress any key to return to the main menu . . . ");
                ReadKey(true);
                Menu goToMain = new Menu();
                goToMain.RunMenu();

            }
                 
             
        }
       

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace dietProjV2
{
    class DietObj
    {
        public string name;
        public int calories;
        public int protein;
        public string contents;
        
        public DietObj(string aName, int aCalories, int aProtein)
        {
            name = aName;
            calories = aCalories;
            protein = aProtein;

            WriteLine($"\nThe {name} plan has {protein} grams of protein and {calories} calories.");
        }
        public DietObj(string aName, int aCalories, int aProtein, string aContents)
        {
            name = aName;
            calories = aCalories;
            protein = aProtein;
            contents = aContents;
            WriteLine($"\n\nThe {name} plan has {protein} grams of protein and {calories} calories to keep you going strong!");
            WriteLine($"The {name} plan includes the following: \n{contents}");
        }
        public DietObj()
        { 
        
        }

        public void DisplayFlavors()
        {
            Clear();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("At BRANDNAME, we offer daily meal plans tailored to your taste buds. Check out all of our awesome flavor packages!");
            
            DateTime startDate = DateTime.Today;
            DateTime endDate = new DateTime(2022, 05, 25);
            TimeSpan difference = endDate - startDate;
            
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"\nJoin us in {difference.Days} days to celebrate the release of a secret new flavor!");

            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("\n  > Very Berry\n  > Chocolate Lovers\n  > Peanut Butter\n  > Tropical Twist\n  > Vanilla\n  > Assorted Fruit\n  > Assorted Dessert");
            
            Menu goBack = new Menu();
            goBack.ReturnToMain();

        }

        public void DisplayPlans()
        {
            Clear();
            WriteLine("We have a daily meal plan suited for just about everyone! Check out our offerings below!");

            DietObj lightyearPlan = new DietObj("Lightyear Plan", 1250, 105, "\n > 1 Sport Shake\n > 2 Standard Shakes\n > 1 Meal Bar\n > 2 Snack Bars\n > 1 Protein Pudding ");
            DietObj nebulaPlan = new DietObj("Nebula Plan", 1600, 115, "\n > 1 Sport Shake\n > 2 Standard Shakes\n > 2 Meal Bars\n > 2 Snack Bars\n > 1 Protein Pudding");
            DietObj supernovaPlan = new DietObj("Supernova Plan", 1800, 145, "\n > 2 Sport Shakes\n > 2 Standard Shakes\n > 2 Meal Bars\n > 2 Snack Bars\n > 1 Protein Pudding");
            DietObj heliosPlan = new DietObj("Helios Plan", 2200, 155, "\n > 3 Sport Shakes\n > 3 Meal Bars\n > 3 Snack Bars\n > 1 Protein Pudding");

            Menu goBack = new Menu();
            goBack.ReturnToMain();

           /*DietObj sportShake = new DietObj("Sport Shake", 200, 30);
           DietObj standShake = new DietObj("Standard Shake", 150, 20);
           DietObj mealBar = new DietObj("Meal Bar", 350, 10);
           DietObj snackBar = new DietObj("Snack Bar", 150, 10);
           DietObj proPudding = new DietObj("Protein Pudding", 100, 5);*/
        }


    }
}

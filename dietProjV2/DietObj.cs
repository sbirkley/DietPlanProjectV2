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
        }

        public DietObj(string aName, int aCalories, int aProtein, string aContents) 
        {
            name = aName;
            calories = aCalories;
            protein = aProtein;
            contents = aContents;
        }

        public DietObj()
        { 
        
        }

        public void Pick(string aName, int aCalories, int aProtein )
        {
            WriteLine($"{name} has {calories} calories and {protein} grams of protein.");
        }

        public void PickPlan()
        {
            WriteLine($"The {name} plan has a total of {calories} calories and {protein} grams of protein to keep you powered up!\n");
            WriteLine($"The {name} plan includes the following: \n{contents}");
        }

        public void DisplayFlavors()
        {
            Clear();
            WriteLine("At BRANDNAME, we offer daily meal plans tailored to your taste buds. Check out all of our awesome flavor packages!");
            WriteLine("\n  > Very Berry\n  > Chocolate Lovers\n  > Peanut Butter\n  > Tropical Twist\n  > Vanilla\n  > Assorted Fruit\n  > Assorted Dessert");
            WriteLine("\n\n Press any key to return to the main menu . . . ");
            ReadKey(true);
            Menu goToMain = new Menu();
            goToMain.RunMenu();

        }

        public void DisplayPlans()
        {
            Clear();
            WriteLine("We have a daily meal plan suited for just about everyone! Check out our offerings below!");

            WriteLine("Press any key to return to the main menu . . . ");
            ReadKey(true);
            Menu goToMain = new Menu();
            goToMain.RunMenu();
           
        }

       
    }
}

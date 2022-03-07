using System;
using static System.Console;

namespace dietProjV2
{
    class Program
    {
        static void Main(string[] args)
        {
            DietObj sportShake = new DietObj("Sport Shake", 200, 30);
            DietObj standShake = new DietObj("Standard Shake", 150, 20);
            DietObj mealBar = new DietObj("Meal Bar", 350, 10);
            DietObj snackBar = new DietObj("Snack Bar", 150, 10);
            DietObj proPudding = new DietObj("Protein Pudding", 100, 5);

            DietObj lightyearPlan = new DietObj("Lightyear Plan", 1250, 105, "\n > 1 Sport Shake\n > 2 Standard Shakes\n > 1 Meal Bar\n > 2 Snack Bars\n > 1 Protein Pudding ");
            DietObj nebulaPlan = new DietObj("Nebula Plan", 1600, 115, "\n > 1 Sport Shake\n > 2 Standard Shakes\n > 2 Meal Bars\n > 2 Snack Bars\n > 1 Protein Pudding");
            DietObj supernovaPlan = new DietObj("Supernova Plan", 1800, 145, "\n > 2 Sport Shakes\n > 2 Standard Shakes\n > 2 Meal Bars\n > 2 Snack Bars\n > 1 Protein Pudding");
            DietObj heliosPlan = new DietObj("Helios Plan", 2200, 155, "\n > 3 Sport Shakes\n > 3 Meal Bars\n > 3 Snack Bars\n > 1 Protein Pudding");


            Menu mainMenu = new Menu();
            mainMenu.RunMenu();
            
            ReadLine();

            /*
             * -- Get crap out of main
               -- Fix values not flooding over from Pick()
               -- Math.Round some numbers
               -- To Lower or To Upper for M/F answers
               -- Consense all of the if/else if stuff
               -- Format everything to make it look ~pretty~
               -- Create a menu where user can scroll/select answer w/ arrow keys instead of entering answer
               -- Git commits
               -- Unit converter
            
             Make sure meets requirements, condense code and make it more readable*/

        }
    }
}

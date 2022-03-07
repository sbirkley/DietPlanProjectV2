﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace dietProjV2
{
    class Menu
    {
        public void RunMenu()
        {
            Clear();
            WriteLine("At BRANDNAME, we are committed to delivering optimal nutrition: ");
            WriteLine("Whether you are here to lose weight, reset, or fuel up, we have you covered!");
            WriteLine("\nWhat would you like to do?");
            WriteLine("   1) Find my meal plan match");
            WriteLine("   2) Explore all plans");
            WriteLine("   3) Explore flavors");
            WriteLine("   4) Exit");
            int answer = Convert.ToInt32(ReadLine());

            if(answer == 1)
            {
                Calculator calc = new Calculator();
                calc.RunCalc();
            }
            else if(answer == 2)
            {
                DietObj plans = new DietObj();
                plans.DisplayPlans();
            }
            else if(answer == 3)
            {
                DietObj flav = new DietObj();
                flav.DisplayFlavors();
            }
            else if(answer == 4)
            {
                WriteLine("Thank you for stopping by! \nPress any key to exit . . . ");
            }
            else
            {
                WriteLine("Please enter a valid response.");
            }
        }
    }
}

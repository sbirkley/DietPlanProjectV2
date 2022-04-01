using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace dietProjV2
{
    class Menu
    {
        public bool RunMenu()
        {
            bool exitLoop = false;
            Clear();
            WriteLine(@"
  ____                      _ _   _                      
 |  _ \                    | | \ | |                     
 | |_) |_ __ __ _ _ __   __| |  \| | __ _ _ __ ___   ___ 
 |  _ <| '__/ _` | '_ \ / _` | . ` |/ _` | '_ ` _ \ / _ \
 | |_) | | | (_| | | | | (_| | |\  | (_| | | | | | |  __/
 |____/|_|  \__,_|_| |_|\__,_|_| \_|\__,_|_| |_| |_|\___|
                                                                                  
");
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("At BRANDNAME, we are committed to delivering optimal nutrition: ");
            WriteLine("Whether you are here to lose weight, reset, or fuel up, we have you covered!");
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("\nWhat would you like to do?");
            WriteLine("   1) Find my meal plan match");
            WriteLine("   2) Explore all plans");
            WriteLine("   3) Explore flavors");
            WriteLine("   4) Exit");
            int answer = Convert.ToInt32(ReadLine());

            switch (answer)
            {
                case 1:
                    Calculator calc = new Calculator();
                    calc.RunCalc();
                    break;
                case 2:
                    DietObj plans = new DietObj();
                    plans.DisplayPlans();
                    break;
                case 3:
                    DietObj flav = new DietObj();
                    flav.DisplayFlavors();
                    break;
                case 4:
                    WriteLine("Thank you for stopping by! \nPress any key to exit . . . ");
                    exitLoop = true;    
                    break;
                default:
                    WriteLine("Please enter a valid response.");
                    break;
            }
            if (answer != 4)
            {
                WriteLine("\n\nPress any key to return to the main menu . . . ");
                ReadKey(true);
                Menu goToMain = new Menu();
            }
            return exitLoop;
        }
        public void ReturnToMain()
        {
            /*WriteLine("\n\nPress any key to return to the main menu . . . ");
            ReadKey(true);
            Menu goToMain = new Menu();
            goToMain.RunMenu();*/
        }
    }
}

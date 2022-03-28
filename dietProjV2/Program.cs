using System;
using static System.Console;

namespace dietProjV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu();
            bool exitLoop = false;
            do
            {
                exitLoop = mainMenu.RunMenu();
            }
            while (!exitLoop);

           
          
            
            //ReadLine();

            /*
               -- Consense all of the if/else if stuff to switch where possible
               -- Format everything to make it look ~pretty~
               -- Create a method with a return value
               -- Git commits
               -- Add some pauses
               -- Turn WeightTimeCalc into subclass of Calculator?
               -- Add ReadMe
               -- Create a couple new meal plans for higher TDEE


                CURRENTLY I HAVE: Unit converter (check if meets reqs), days remaining calculator, master loop

                ALSO: Interview, type up code event entry thing, finish PluralSight
               */

        }
    }
}

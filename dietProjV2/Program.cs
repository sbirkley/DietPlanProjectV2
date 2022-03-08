using System;
using static System.Console;

namespace dietProjV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu();
            mainMenu.RunMenu();
            
            ReadLine();

            /*
             
               -- Fix values not flooding over from Pick()
               -- Consense all of the if/else if stuff to switch where possible
               -- Format everything to make it look ~pretty~
               -- Create a menu where user can scroll/select answer w/ arrow keys instead of entering answer
               -- Git commits
               -- Unit converter
               -- Countdown to new flavor release clock*/

        }
    }
}

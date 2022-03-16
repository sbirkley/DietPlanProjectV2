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
               -- Consense all of the if/else if stuff to switch where possible
               -- Format everything to make it look ~pretty~
               -- Create a menu where user can scroll/select answer w/ arrow keys instead of entering answer if time allows.
               -- Git commits
               -- Unit converter  --> does what I have work?
               -- Round days on release date clock
               -- Add some pauses
               -- Turn WeightTimeCalc into subclass of Calculator?


                CURRENTLY I HAVE: Unit converter (check if meets reqs), days remaining calculator, master loop
               */

        }
    }
}

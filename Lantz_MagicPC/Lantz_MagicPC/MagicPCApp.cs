using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Lantz_MagicPC
{
    class MagicPCApp
    {
        static void Main(string[] args)
        {

            //Instantiating objects
            Info info = new Info();
            MagicPCUI view = new MagicPCUI(); 
            MagicPC magic = new MagicPC();

            //Displays my info for the class, instructor, and current assignment information
            info.DisplayInfo("Assignment 4: Magic PC");

            //Using a view object to display instructions to the user
            view.userInstructions();

            WriteLine("\nHit [enter] to continue...");
            ReadLine();

            do
            {
                Clear();//Clears the screen of all information 

                //Using view object to ask the user to input a question
                view.GetUserQuestion();
               
                //Using magicPC object to display the answer to the user using a randomly generated number
                magic.GetUserAnswer();

            } while (!view.KeepPlaying());

            //Displays a message saying goodbye
            view.Goodbye();

            Console.Read();

        }//End of main
    } //End of class
}//End of namespace

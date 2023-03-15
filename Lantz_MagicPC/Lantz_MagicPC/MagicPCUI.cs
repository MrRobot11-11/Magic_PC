using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Lantz_MagicPC
{
    //View class

    class MagicPCUI
    {

        

        //This method will display an introduction and instructions to the user
        public void userInstructions()
        {
            string barrier = "**************************************************************************";
            WriteLine("\n" +barrier );
            WriteLine("\nWelcome my friend.  Come closer.  That's right.");
            WriteLine("\nThis is the Magic PC screen.  All your questions will be answered!");
            WriteLine("Just enter a question and the Magic PC screen will give you the answer!");
            WriteLine("\nHowever, it must be a question that can be answered with a yes or a no.");
            WriteLine("To exit the program, just hit the [enter] key.");
            WriteLine("\n" + barrier);
        }

        //This method asks the user to ask a question, then stores the question in a variable
        public void GetUserQuestion()
        {
            WriteLine("\n\n\nEnter your question if you dare...");
            WriteLine("\n");
            string userQuestion = ReadLine();

        }

        //Method that will ask the user to type 1 to quit or 0 to ask another question
        //Method will be used in a do/while loop in Main
        public bool KeepPlaying()
        {
           
            WriteLine("\n\n\n\t[1] to ask another question.");
            WriteLine("\t[enter] to quit.");
            string input = ReadLine();
            if (input == "")
                return true ;
            else if (double.Parse(input) == 1)
                return false;
            else
                return false;
                    }

        //Displays a nice message to the user upon leaving the app
        public void Goodbye()
        {
            Clear();
            WriteLine("\n\n\nUntil we meet again, may you have a good fortune.");
            WriteLine("\n[enter] to exit");
        }

    }//End of class

}//End of namespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Lantz_MagicPC
{
    
    //Model
    //Generate random number here

    class MagicPC
    {
        Random number = new Random(); //Random object to generate a random number
        private int randomNumber; //This will hold the random number after it is generated

        //An array to hold the answers the magic pc can use as responses
        private string[] magicPcAnswers = { "It is certain.", "It is decidely so.", "As I see it, yes.", "Reply hazy, try again.",
                                                                                        "Cannot predict now", "Don't count on it.", "My sources say no.", "Outlook not so good",
                                                                                         "Signs point to yes.", "You may rely on it."};

        //This method first generates a random number, then uses that number to choose a question from the magicPcAnswers array
        //The random number that is generated is used to access the index of the array
        public void GetUserAnswer()
        {
            randomNumber = number.Next(0, 10);
            WriteLine("\n\n");
            WriteLine("\t\t" + magicPcAnswers[randomNumber]);
            
        }







    }//End of class
}//End of namespace

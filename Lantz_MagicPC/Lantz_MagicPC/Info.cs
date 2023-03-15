using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lantz_MagicPC
{
    class Info
    {
        public void DisplayInfo(string currentAssignment)
        {
            string barrier = "**************************************************************************";
            Console.WriteLine(barrier);
            Console.WriteLine("\nName: \t\tSteve Lantz");
            Console.WriteLine("Course: \tITDEV-115-501");
            Console.WriteLine("Instructor:\tJanese Christie");
            Console.WriteLine("Assignment:\t" + currentAssignment);
            Console.WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString() + "\n");
            Console.WriteLine(barrier);
        }
    }

}

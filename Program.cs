

using System;
using System.Windows.Forms;

namespace DateTest1
{
    // TimeTest1 uses creates and uses a Time1 object
    class DateTest1
    {
        // main entry point for application
        static void Main(string[] args)
        {
            RCDate date = new RCDate();  // calls Date constructor
            string output;

            // assign string representation of (0,0,0) to date constructor
            output =  "Initial Date using constructor is: " +
               date.GetStringDate();
             // should catch exception as 0 date are invalid

            // attempt valid date settings
            date.SetDate(1999, 12, 30);

            // append new string representations of date to output
            output += "\n\nDate after setdate is: " +
               date.GetStringDate();

            date.IncDate();
             //attempt invalid date settings
           // date.SetDate(1999, -9, 9); // only sets the valid part i.e year and day

            output += "\n\nAfter Incresing date " +
              "\nDate: " + date.GetStringDate();
              

            MessageBox.Show(output, "Testing Class Time1");

        } // end method Main

    } // end class Date
}


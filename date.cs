

using System;
using System.Windows.Forms;


namespace DateTest1
{
    // Dateclass class definition
    public class RCDate
    {
        private int yearmonthday;

        // Time1 constructor initializes instance variables to 
        // zero to set default time to midnight
        public RCDate()
        {
            SetDate(0, 0, 0);
        }

        //using property to get and set years
        public int Year
        {
            get
            {
                return ( yearmonthday/ 10000); //gives the years
            }
            set
            {
               
                
                    int tempvalue = yearmonthday;
                    int month = (yearmonthday / 100) % 100;
                    int day = ((yearmonthday % 100) % 100);
                    if ((value >= 0 && value < 3000))
                    {

                    yearmonthday = value * 10000 + month * 100 + day;
                    }
                    else
                    {
                        yearmonthday = value * 10000 + day;
                        throw new Exception( message: "Years value out of range");
                    }
                
               
               

            }
        }
        
        //using property to get and set month
        public int Month
        {
            get
            {
                return ((yearmonthday/ 100) % 100); //gives back  the months
            }

            set //sets the months after checking validity
            {
                int tempvalue = yearmonthday;
                int years = yearmonthday/10000;

                if (value >= 0 && value <=12)
                {
                    yearmonthday = years * 10000 + value * 100 + ((tempvalue % 100) % 100);
                }
                else
                {
                    yearmonthday = years * 10000  + ((tempvalue % 100) % 100);
                    throw new Exception(message: "Months value out of range");
                }


            }
        }


        public int Day
        {
            get
            {
                return ((yearmonthday % 100) % 100); //gives the days
            }

            set
            {//sets the days
                
                    int years = yearmonthday / 10000;
                    int months = ((yearmonthday / 100) % 100);

                    if (value > 0 && value < 32)
                    {
                        yearmonthday = (years * 10000) + (months * 100 + value);
                    }
                    else
                    {
                        yearmonthday = (years * 10000) + (months * 100 );
                        throw new Exception("Days value out of range");
                    }
               


            }
        }


        // Sets the date in year month and day format
        public void SetDate(
           int year, int month, int day)
        {

            try
            { 
                this.Year = year;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                this.Month = month;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                this.Day= day;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } // end method SetDate

        // Get the Date in Defined Format
        public string GetStringDate()
        {
            return String.Format(
               "{0:D2}/{1:D2}/{2:D4}", this.Month, this.Day, this.Year);
        }

        public void IncDate()
        {
           if (this.Day>0 && this.Day < 30)
           {
                this.Day=this.Day+1;
           }
           else if (this.Day == 30)
           {
                if (this.Month == 12)
                {
                    this.Day = 1;
                    this.Month = 1;
                    this.Year = this.Year + 1;
                }
                else if (this.Month>=1 && this.Month < 12)
                {
                    this.Day = 1;
                    this.Month = this.Month + 1;
                }
            }


        }

        

    } // end class DAte1
}

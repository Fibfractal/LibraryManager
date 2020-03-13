// Phone.cs
// Created: 2019-05-21 by Robert Nilsson
// Purpose: Project part 2 VG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPart2
{
    /// <summary>
    /// An object of this class holds data, as mobile and home phone numbers 
    /// </summary>
    public class Phone
    {
        private string mobilePhoneNbr;  // Declares a string instance variable
        private string homePhoneNbr;    // Declares a string instance variable

        /// <summary>
        /// The default constructor, calls the constructor with two parameters
        /// in this class. 
        /// </summary>
        public Phone() : this(string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// A constructor, creates an object of the
        /// Phone class, and initiates it's instance
        /// variables with argument values. It has 
        /// two parameters. 
        /// </summary>
        /// <param name="myMobilePhoneNbr">myMobilePhoneNbr as string</param>
        /// <param name="myHomePhoneNbr">myHomePhoneNbr as string</param>
        public Phone(string myMobilePhoneNbr, string myHomePhoneNbr)
        {
            mobilePhoneNbr = myMobilePhoneNbr;
            homePhoneNbr = myHomePhoneNbr;
        }

        /// <summary>
        /// This property gets or sets the instance variable mobilePhoneNbr
        /// </summary>
        public string MobilePhoneNbr
        {
            get
            {
                return mobilePhoneNbr;
            }
            set
            {
                // Is the value not empty ?
                if (value != string.Empty)
                {
                    mobilePhoneNbr = value;
                }
            }
        }

        /// <summary>
        /// This property gets or sets the instance variable homePhoneNbr
        /// </summary>
        public string HomePhoneNbr
        {
            get
            {
                return homePhoneNbr;
            }
            set
            {
                // Instance variable not obligatory,
                // could be changed to empty
                homePhoneNbr = value;
 
            }
        }

        /// <summary>
        /// The method validates the instance variable
        /// mobilePhoneNbr. If it's not empty, the method 
        /// returns true, else false.
        /// </summary>
        /// <returns>A boolean value</returns>
        public bool ValidateInput()
        {
            return mobilePhoneNbr != string.Empty;
        }

        /// <summary>
        /// This method displays the values of the instance
        /// variables of this class, as a formatted string.
        /// </summary>
        /// <returns>A formatted string</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0,-11} {1,-14}", mobilePhoneNbr, homePhoneNbr);
            return strOut;
        }

    }
}

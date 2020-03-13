// Email.cs
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
    /// An object of this class holds data, as personal and work email
    /// </summary>
    public class Email
    {
        private string personalEmail;   // Declares a string instance variable
        private string workEmail;       // Declares a string instance variable

        /// <summary>
        /// The default constructor, calls the constructor with two parameters
        /// in this class. 
        /// </summary>
        public Email() : this(string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// A constructor, creates an object of the
        /// Email class, and initiates it's instance
        /// variables with argument values. It has 
        /// two parameters. 
        /// </summary>
        /// <param name="myPersonalEmail">myPersonalEmail as string</param>
        /// <param name="myWorkEmail">myWorkEmail as string</param>
        public Email(string myPersonalEmail, string myWorkEmail)
        {
            personalEmail = myPersonalEmail;
            workEmail = myWorkEmail;
        }

        /// <summary>
        /// This property gets or sets the instance variable personalEmail
        /// </summary>
        public string PersonalEmail
        {
            get
            {
                return personalEmail;
            }
            set
            {
                // Is the value not empty ?
                if (value != string.Empty)
                {
                    personalEmail = value;
                }
            }
        }

        /// <summary>
        /// This property gets or sets the instance variable workEmail
        /// </summary>
        public string WorkEmail
        {
            get
            {
                return workEmail;
            }
            set
            {
                // Instance variable not obligatory,
                // could be changed to empty
                workEmail = value;
            }
        }

        /// <summary>
        /// The method validates the instance variable
        /// personalEmail. If it's not empty, the method 
        /// returns true, else false.
        /// </summary>
        /// <returns>A boolean value</returns>
        public bool ValidateInput()
        {
            return personalEmail != string.Empty;
        }

        /// <summary>
        /// This method displays the values of the instance
        /// variables of this class, as a formatted string.
        /// </summary>
        /// <returns>A formatted string</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0,-31} {1,-15}", personalEmail, workEmail);
            return strOut;
        }

    }
}

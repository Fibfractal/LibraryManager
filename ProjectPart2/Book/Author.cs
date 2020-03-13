// Author.cs
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
    /// An object of this class holds data, as first and last name of an author
    /// </summary>
    public class Author
    {
        private string firstName;   // Declares a string instance variable
        private string lastName;    // Declares a string instance variable

        /// <summary>
        /// The default constructor, calls the constructor with two parameters
        /// in this class. 
        /// </summary>
        public Author() : this(string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// A constructor, creates an object of the
        /// Author class, and initiates it's instance
        /// variables with argument values. It has 
        /// two parameters. 
        /// </summary>
        /// <param name="myFirstName">myFirstname as string</param>
        /// <param name="myLastName">myLastName as string</param>
        public Author(string myFirstName, string myLastName)
        {
            firstName = myFirstName;
            lastName = myLastName;
        }

        /// <summary>
        /// This property gets or sets the instance variable firstName
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                // Is the value not empty?
                if (value != string.Empty)
                {
                    firstName = value;
                }
            }
        }

        /// <summary>
        /// This property gets or sets the instance variable lastName
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                // Is the value not empty?
                if (value != string.Empty)
                {
                    lastName = value;
                }
            }
        }

        /// <summary>
        /// This property gets the full name from the instance variables of this class
        /// </summary>
        public string FullName
        {
            get
            {
                string fullName = lastName + " " + firstName;
                return fullName;
            }
        }

        /// <summary>
        /// The method validates the instance variables firstName and
        /// lastName. If they are not empty, the method 
        /// returns true, else false. 
        /// </summary>
        /// <returns>A boolean value</returns>
        public bool ValidateInput()
        {
            return (firstName != string.Empty) && (lastName != string.Empty);
        }

        /// <summary>
        /// This method displays the values of the instance
        /// variables of this class, as a formatted string. 
        /// </summary>
        /// <returns>A formatted string</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0,-34}", FullName);
            return strOut;
        }
    }
}

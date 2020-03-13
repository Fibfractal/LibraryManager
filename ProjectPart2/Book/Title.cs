// Title.cs
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
    /// An object of this class holds data, as title of the book
    /// </summary>
    public class Title
    {
        private string myTitle; // Declares a string instance variable

        /// <summary>
        /// The default constructor, calls the constructor with one parameter
        /// in this class. 
        /// </summary>
        public Title() : this(string.Empty)
        {
        }

        /// <summary>
        /// A constructor, creates an object of the
        /// Title class, and initiates it's instance
        /// variables with argument values. It has 
        /// one parameter. 
        /// </summary>
        /// <param name="title">title as string</param>
        public Title(string title)
        {
            myTitle = title;
        }

        /// <summary>
        /// This property gets or sets the instance variable title 
        /// </summary>
        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                // Is the value not empty?
                if (value != string.Empty)
                {
                    myTitle = value;
                }
            }
        }

        /// <summary>
        /// The method validates the instance variable
        /// title. If it's not empty, the method 
        /// returns true, else false. 
        /// </summary>
        /// <returns>A boolean value</returns>
        public bool ValidateInput()
        {
            return myTitle != string.Empty;
        }

        /// <summary>
        /// This method displays the values of the instance
        /// variable of this class, as a formatted string. 
        /// </summary>
        /// <returns>A formatted string</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0,-28}", myTitle);
            return strOut;
        }
    }
}

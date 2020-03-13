// Address.cs
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
    /// An object of this class holds data, as street, zip code and city
    /// </summary>
    public class Address
    {
        private string street;      // Declares a string instance variable
        private string zipCode;     // Declares a string instance variable
        private string city;        // Declares a string instance variable

        /// <summary>
        /// The default constructor, calls the constructor with three parameters
        /// in this class. 
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// A constructor, creates an object of the
        /// Address class, and initiates it's instance
        /// variables with argument values. It has 
        /// three parameters. 
        /// </summary>
        /// <param name="myStreet">myStreet as string</param>
        /// <param name="myZipCode">myZipCode as string</param>
        /// <param name="myCity">myCity as string</param>
        public Address(string myStreet, string myZipCode, string myCity)
        {
            street = myStreet;
            zipCode = myZipCode;
            city = myCity;
        }

        /// <summary>
        /// This property gets or sets the instance variable street
        /// </summary>
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                // Is the value not empty ?
                if (value != string.Empty)
                {
                    street = value;
                }
            }
        }

        /// <summary>
        /// This property gets or sets the instance variable zipCode
        /// </summary>
        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                // Is the value not empty ?
                if (value != string.Empty)
                {
                    zipCode = value;
                }
            }
        }

        /// <summary>
        /// This property gets or sets the instance variable city
        /// </summary>
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                // Is the value not empty ?
                if (value != string.Empty)
                {
                    city = value;
                }
            }
        }

        /// <summary>
        /// The method validates the instance variables
        /// street, zipCode and city. If it's not empty, 
        /// the method returns true, else false.
        /// </summary>
        /// <returns>A boolean value</returns>
        public bool ValidateInput()
        {
            return (street != string.Empty) && (zipCode != string.Empty) && (city != string.Empty);
        }

        /// <summary>
        /// This method displays the values of the instance
        /// variables of this class, as a formatted string.
        /// </summary>
        /// <returns>A formatted string</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0,-20} {1,-8} {2,-12}", street, zipCode, city);
            return strOut;
        }
    }
}

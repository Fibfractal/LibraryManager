// BookLender.cs
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
    /// An object of this class holds data, as lender id, first and last name,
    /// home address, phone numbers, email addresses and a list of borrowed books.
    /// </summary>
    public class BookLender
    {
        private int lenderID;               // Declares an integer instance variable
        private string firstName;           // Declares a string instance variable
        private string lastName;            // Declares a string instance variable
        private Address myAddress;          // Declares an instance variable of the Adress class
        private Phone myPhone;              // Declares an instance variable of the Phone class
        private Email myEmail;              // Declares an instance variable of the Email class
        private BookManager myBookManager;  // Declares an instance variable of the BookManager class

        /// <summary>
        /// The default constructor, calls the constructor with seven parameters
        /// in this class. 
        /// </summary>
        public BookLender() : this(0, string.Empty, string.Empty, new Address(), new Phone(), new Email(), new BookManager())
        {
        }

        /// <summary>
        /// A constructor, creates an object of the
        /// BookLender class, and initiates it's instance
        /// variables with argument values. It has 
        /// seven parameters. 
        /// </summary>
        /// <param name="myLenderID">myLenderID as string</param>
        /// <param name="myFirstName">myFirstName as string</param>
        /// <param name="myLastName">myLastName as string</param>
        /// <param name="address">address as an Address object</param>
        /// <param name="phone">phone as a Phone object</param>
        /// <param name="email">email as an Email object</param>
        /// <param name="bookManager">bookManager as a bookManager object</param>
        public BookLender(int myLenderID, string myFirstName, string myLastName,  Address address, Phone phone, Email email, BookManager bookManager )
        {
            lenderID = myLenderID;
            firstName = myFirstName;
            lastName = myLastName;
            myAddress = address;
            myPhone = phone;
            myEmail = email;
            myBookManager = bookManager;
        }

        /// <summary>
        /// This property gets or sets the instance variable lenderID
        /// </summary>
        public int LenderID
        {
            get
            {
                return lenderID;
            }
            set
            {
                // Is the value not empty ?
                if (value != 0)
                {
                    lenderID = value;
                }
            }
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
                // Is the value not empty ?
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
                // Is the value not empty ?
                if (value != string.Empty)
                {
                    lastName = value;
                }
            }
        }

        /// <summary>
        /// This property gets full name from the instance variables
        /// firstName and lastName.
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
        /// This property gets or sets the instance variable myAdress
        /// </summary>
        public Address MyAddress
        {
            get
            {
                return myAddress;
            }
            set
            {
                // Is the value not null ?
                if (value != null)
                {
                    myAddress = value;
                }
            }
        }

        /// <summary>
        /// This property gets or sets the instance variable myPhone
        /// </summary>
        public Phone MyPhone
        {
            get
            {
                return myPhone;
            }
            set
            {
                // Is the value not null ?
                if (value != null)
                {
                    myPhone = value;
                }
            }
        }

        /// <summary>
        /// This property gets or sets the instance variable myEmail
        /// </summary>
        public Email MyEmail
        {
            get
            {
                return myEmail;
            }
            set
            {
                // Is the value not null ?
                if (value != null)
                {
                    myEmail = value;
                }
            }
        }

        /// <summary>
        /// This property gets or sets the instance variable myBookManager
        /// </summary>
        public BookManager MyBookManager
        {
            get
            {
                return myBookManager;
            }
            set
            {
                // Is the value not null ?
                if (value != null)
                {
                    myBookManager = value;
                }
            }
        }

        /// <summary>
        /// The method validates the instance variables firstName and
        /// lastName. If it's not empty, the method 
        /// returns true, else false.
        /// </summary>
        /// <returns>A boolean value</returns>
        public bool ValidateInput()
        {
            return (firstName != string.Empty) && (lastName != string.Empty);
        }

        /// <summary>
        /// The method gets the next return date of a book which is
        /// next inline to be returned to the library for a lender.
        /// </summary>
        /// <returns>A DateTime object</returns>
        public DateTime GetNextReturnDate()
        {
            return myBookManager.NextReturnDate();
        }

        /// <summary>
        /// Method returnes as string of the next return date for lenders
        /// who have a borrowed at least a book. Fore those who have not,
        /// will an empty string be returned.
        /// </summary>
        /// <returns>A string</returns>
        private string DisplayDateString()
        {
            // Lenders who don't have borrowed a book, have the max date value assigned.
            // Is the next return date a max date value ?
            if ((GetNextReturnDate() - DateTime.MaxValue).TotalDays == 0)
            {
                return string.Empty;
            }
            else
            {
                // Else, will return the string of a real next return date
                string strOut = string.Format("{0}", GetNextReturnDate().ToShortDateString());
                return strOut;
            }

        }

        /// <summary>
        /// This method displays the values of the instance
        /// variables of this class, as a formatted string.
        /// </summary>
        /// <returns>A formatted string</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0,-10} {1,-23} {2,-20} {3,-16} {4,-17} {5,-21} {6} ",
                lenderID, FullName, DisplayDateString(), myBookManager.DaysToReturnBook(), myBookManager.Count,
                myPhone.MobilePhoneNbr, myEmail.PersonalEmail);

            return strOut;
        }

    }
}

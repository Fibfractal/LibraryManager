// BookLenderForm.cs
// Created: 2019-05-21 by Robert Nilsson
// Purpose: Project part 2 VG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPart2
{
    /// <summary>
    /// This class reads personal information of book lenders, as full name, phone
    /// numbers, email addresses and home address. It's both a client and a server
    /// class. A new form can be opened to manage information of borrowed books.
    /// </summary>
    public partial class BookLenderForm : Form
    {
        private BookLender bookLender;      // Declares an instance variable of the BookLender class
        private bool closeForm;             // Declares a boolean instance variable, used as a flag

        /// <summary>
        /// The default constructor, calls the constructor with one parameter
        /// in this class. The controls in the GUI is initiated.
        /// </summary>
        public BookLenderForm() : this(string.Empty)
        {
        }

        /// <summary>
        /// A constructor, creates an object of the
        /// BookLenderForm class, and initiates it's instance
        /// variables with argument values. It has 
        /// one parameter. The controls in the GUI is initiated.
        /// </summary>
        /// <param name="titleText">titleText as a string</param>
        public BookLenderForm(string titleText)
        {
            InitializeComponent();
            bookLender = new BookLender();
            InitializeGUI(titleText);
        }

        /// <summary>
        /// A constructor, creates an object of the
        /// BookLenderForm class, and initiates it's instance
        /// variables with argument values. It has 
        /// two parameters. The controls in the GUI is initiated.
        /// </summary>
        /// <param name="titleText">titleText as a string</param>
        /// <param name="savedBookLender">savedBookLender as a BookLender object</param>
        public BookLenderForm(string titleText, BookLender savedBookLender)
        {
            InitializeComponent();
            bookLender = savedBookLender;
            InitializeGUI(titleText);
            // The GUI is filled with data from saved BookLender object
            FillSavedDataToGUI(savedBookLender);
        }

        /// <summary>
        /// This property gets or sets the instance variable bookLender
        /// </summary>
        public BookLender MyBookLender
        {
            get
            {
                return bookLender;
            }
            set
            {
                // Is the value not null ?
                if (value != null)
                {
                    bookLender = value; 
                }
            }
        }

        /// <summary>
        /// The method initializes the GUI. Has the
        /// title text as one parameter.
        /// </summary>
        /// <param name="titleText">titleText as a string</param>
        private void InitializeGUI(string titleText)
        {
            // Assigned the GUI with a title
            this.Text = titleText;

            // Is this a saved bookLender with an assigned ID ?
            if (bookLender.LenderID != 0)
            {
                // Show the book lender ID in the GUI
                lbl_IdBookLender.Text = string.Format("{0}", bookLender.LenderID);
            }
            // If the form is called to be closed, it will
            // be closed as a default.
            closeForm = true;
            // Update the GUI
            UpdateGUI();
        }

        /// <summary>
        /// The method updates the GUI and clears all
        /// the textboxes.
        /// </summary>
        private void UpdateGUI()
        {
            ClearTextBoxes();
        }

        /// <summary>
        /// The method clears all the textboxes int the GUI
        /// </summary>
        private void ClearTextBoxes()
        {
            tbx_FirstName.Text = string.Empty;
            tbx_LastName.Text = string.Empty;
            tbx_MobilePhoneNbr.Text = string.Empty;
            tbx_HomePhoneNbr.Text = string.Empty;
            tbx_PrivateEmail.Text = string.Empty;
            tbx_WorkEmail.Text = string.Empty;
            tbx_Street.Text = string.Empty;
            tbx_ZipCode.Text = string.Empty;
            tbx_City.Text = string.Empty;
        }

        /// <summary>
        /// The method fills all the textboxes in the GUI with data
        /// from a saved book lender object.
        /// </summary>
        /// <param name="savedBookLender">savedBookLender as a BookLender object</param>
        private void FillSavedDataToGUI(BookLender savedBookLender)
        {
            // Is the book lender object not null ?
            if (savedBookLender != null)
            {
                tbx_FirstName.Text = savedBookLender.FirstName;
                tbx_LastName.Text = savedBookLender.LastName;
                tbx_MobilePhoneNbr.Text = savedBookLender.MyPhone.MobilePhoneNbr;
                tbx_HomePhoneNbr.Text = savedBookLender.MyPhone.HomePhoneNbr;
                tbx_PrivateEmail.Text = savedBookLender.MyEmail.PersonalEmail;
                tbx_WorkEmail.Text = savedBookLender.MyEmail.WorkEmail;
                tbx_Street.Text = savedBookLender.MyAddress.Street;
                tbx_ZipCode.Text = savedBookLender.MyAddress.ZipCode;
                tbx_City.Text = savedBookLender.MyAddress.City;
            }
        }

        /// <summary>
        /// This method reads and assignes a book lender object with; first and last name of a lender,
        /// mobile and home phone numbers, personal and work email addresses and home address data.
        /// </summary>
        private void ReadBookLenderData()
        {
            bookLender.FirstName = tbx_FirstName.Text;
            bookLender.LastName = tbx_LastName.Text;
            bookLender.MyPhone.MobilePhoneNbr = tbx_MobilePhoneNbr.Text;
            bookLender.MyPhone.HomePhoneNbr = tbx_HomePhoneNbr.Text;
            bookLender.MyEmail.PersonalEmail = tbx_PrivateEmail.Text;
            bookLender.MyEmail.WorkEmail = tbx_WorkEmail.Text;
            bookLender.MyAddress.Street = tbx_Street.Text;
            bookLender.MyAddress.ZipCode = tbx_ZipCode.Text;
            bookLender.MyAddress.City = tbx_City.Text;
        }

        /// <summary>
        /// Method validates lender name, phone, email and address as input.
        /// If invalid error messages will be shown. Method will
        /// return true if valid, else false.
        /// </summary> 
        /// <returns>A boolean value</returns>
        public bool ValidateInput()
        {
            // Validates input as boolean values
            bool nameOk = bookLender.ValidateInput();
            bool phoneOk = bookLender.MyPhone.ValidateInput();
            bool emailOk = bookLender.MyEmail.ValidateInput();
            bool addressOk = bookLender.MyAddress.ValidateInput();

            // Error messages, if invalid input
            ErrorMessages(nameOk, phoneOk, emailOk, addressOk);

            // If all valid input returns true else false
            return nameOk && phoneOk && emailOk && addressOk;

        }

        /// <summary>
        /// Method tests if error messages should be thrown.
        /// Book lender name, phone, email and home address as boolean parameters.
        /// </summary>
        /// <param name="nameOk">nameOk as a boolean value</param>
        /// <param name="phoneOk">phoneOk as a boolean value</param>
        /// <param name="emailOk">emailOk as a boolean value</param>
        /// <param name="addressOk"addressOk as a boolean value</param>
        private void ErrorMessages(bool nameOk, bool phoneOk, bool emailOk, bool addressOk)
        {
            // Is the boolean input not true ?
            if (!nameOk)
            {
                MessageBox.Show("You must enter the lenders first and last name!", "Error message!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!phoneOk)
            {
                MessageBox.Show("You must enter at least the mobile phone number!", "Error message!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!emailOk)
            {
                MessageBox.Show("You must enter at least the personal email!", "Error message!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!addressOk)
            {
                MessageBox.Show("You must enter all address fields!", "Error message!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// This method is called when the Ok button is pressed in the GUI.
        /// Lender data from the GUI is read.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            ReadBookLenderData();
        }

        /// <summary>
        /// This method is called when the Cancel button is pressed in the GUI.
        /// A messagebox is shown with a yes or no option to close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // Is the yes or no button pressed in the messagebox ?
            if (MessageBox.Show("Are you sure you want to exit, no new lender data or changed data from this form will be saved?", "Think again", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                // The form is not closed
                closeForm = false;
            }
        }

        /// <summary>
        /// This method is called when the form is to be 
        /// closed with the Cancel button. Depending on
        /// the status of the instance variable closeForm,
        /// e.Cancel is true or false. False close the form
        /// ,true keeps it open. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookLenderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Is flag true?
            if (closeForm)
            {
                e.Cancel = false;  // Close form
            }
            else
            {
                e.Cancel = true; // Keep form open
            }
            closeForm = true;  // Resets flag to true
        }

        /// <summary>
        /// The method is called when the Book Manager button is pressed.
        /// It opens the BookForm GUI, to manage borrowed books for lenders.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BookManager_Click(object sender, EventArgs e)
        {
            // A new book form is created with a list of books for a lender as a parameter.
            BookForm formBook = new BookForm(bookLender.MyBookManager);
            // Opens the form
            formBook.ShowDialog();
        }
    }
}

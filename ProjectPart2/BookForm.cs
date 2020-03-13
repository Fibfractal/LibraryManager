// BookForm.cs
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
    /// This class reads book information, as ISBN number, fullname of author, book title,
    /// book genre and return date of book. This is presented in a book list in the GUI,
    /// where borrowed books can be added, edited or deleted. The class is a server class.
    /// </summary>
    public partial class BookForm : Form
    {
        private BookManager myBookManager;  // Declares an instance variable of the BookManager class

        /// <summary>
        /// The default constructor creates an object of the BookForm class.
        /// The controls in the GUI is initiated.
        /// </summary>
        public BookForm()
        {
            InitializeComponent();
            myBookManager = new BookManager();
            InitializeGUI();
        }

        /// <summary>
        /// A constructor, creates an object of the
        /// BookForm class, and initiates it's instance
        /// variables with argument values. It has 
        /// one parameter. The controls in the GUI is
        /// also initiated.
        /// </summary>
        /// <param name="savedBookManager">A BookManager object</param>
        public BookForm(BookManager savedBookManager)
        {
            InitializeComponent();
            myBookManager = savedBookManager;
            InitializeGUI();
        }

        /// <summary>
        /// This method initiates the the controls in the GUI
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "Book Manager";
            UpdateGUI();
        }

        /// <summary>
        /// This method updates all the controls in the GUI
        /// </summary>
        private void UpdateGUI()
        {
            btn_Change.Enabled = false;
            btn_Delete.Enabled = false;
            ClearTextboxes();
            SetDateTimePicker();
            SetTooTip();
            FillComboBox();
            UpdateList();
        }

        /// <summary>
        /// This method sets a tooltip to the DateTimePicker control
        /// </summary>
        private void SetTooTip()
        {
            tp_ReturnDate.SetToolTip(dtp_DateTimePicker, "Click on Calender to set date");
        }

        /// <summary>
        /// This method sets the format, cultureinfo and a default value to
        /// the DateTimePicker control
        /// </summary>
        private void SetDateTimePicker()
        {
            // Since the program is written for english speaking, the format for date and time is adapted to Great Britain
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-GB");
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;

            // A custom format is chosen
            dtp_DateTimePicker.Format = DateTimePickerFormat.Custom;
            dtp_DateTimePicker.CustomFormat = "yyyy - MM - dd ";
            // A default date and time value is set
            dtp_DateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// This method clears all the textboxes in the GUI
        /// </summary>
        private void ClearTextboxes()
        {
            tbx_ISBN.Text = string.Empty;
            tbx_AuthorFirstName.Text = string.Empty;
            tbx_AuthorLastName.Text = string.Empty;
            tbx_Title.Text = string.Empty;
        }

        /// <summary>
        /// This method sorts the book list. Then it's transferred to
        /// a string array containing book data and added to the listbox,
        /// displaying the data in the GUI.
        /// </summary>
        private void UpdateList()
        {
            // The book list is sorted by return date
            myBookManager.MyBookList.Sort((x, y) => x.ReturnDate.CompareTo(y.ReturnDate));
            // The lisbox in GUI is cleared
            lbx_BookList.Items.Clear();
            // The book list is added to listbox
            lbx_BookList.Items.AddRange(myBookManager.ToStringArray());
        }

        /// <summary>
        /// This method fills the combobox control in the GUI with
        /// the different book genres. The string format of these
        /// genres is changed before the controle is filled.
        /// </summary>
        private void FillComboBox()
        {
            // Clears the combobox
            cbx_BookType.Items.Clear();
            // A string array is initiated with book genres as string
            string[] genre = Enum.GetNames(typeof(BookGenre));
            // Iterating through the array
            foreach (var item in genre)
            {
                // String format is changed, then added to the combobox
                cbx_BookType.Items.Add(item.Replace("_", " "));
            }
            // The book genre Action and adventure is set as a default value in the combobox
            cbx_BookType.SelectedIndex = (int)BookGenre.Action_and_adventure;
        }

        /// <summary>
        /// This method reads ISBN number, first and last name of the author, book title,
        /// book genre and the return date of the book. All data is assigned to a book object.
        /// Method returnes that book object.
        /// </summary>
        /// <returns>A book object</returns>
        private Book ReadData()
        {
            Book book = new Book();
            // Values from textboxes is assigned to the book object
            book.ISBN = tbx_ISBN.Text;
            book.MyAuthor.FirstName = tbx_AuthorFirstName.Text;
            book.MyAuthor.LastName = tbx_AuthorLastName.Text;
            book.MyTitle.MyTitle = tbx_Title.Text;
            // Selected index in combobox is converted to BookGenre class
            book.MyBookGenre = (BookGenre)cbx_BookType.SelectedIndex;
            // Date and time value is chosen from date time control
            book.ReturnDate = dtp_DateTimePicker.Value;

            return book;
        }

        /// <summary>
        /// Method validates ISBN, author name and book title as input.
        /// If invalid input, error messages will be shown. Method will
        /// return true if valid, else false.
        /// </summary>
        /// <param name="book">book as an Book object</param>
        /// <returns>A boolean value</returns>
        private bool ValidateInput(Book book)
        {
            // Input is validated
            bool okISBN = book.ValidateInput();
            bool okName = book.MyAuthor.ValidateInput();
            bool okTitle = book.MyTitle.ValidateInput();

            // Error messages, if invalid input
            ErrorMessages(okISBN, okName, okTitle);

            // Valid input returns true else false
            return okISBN && okName && okTitle;
        }

        /// <summary>
        /// Method tests if error messages should be thrown.
        /// ISBN, author name and book title as boolean input.
        /// </summary>
        /// <param name="okISBN">okISBN as a boolean value</param>
        /// <param name="okName">okName as a boolean value</param>
        /// <param name="okTitle">okTitle as a boolean value</param>
        private void ErrorMessages( bool okISBN, bool okName, bool okTitle)
        {
            // Is the boolean input not true?
            if (!okISBN)
            {
                MessageBox.Show("You must enter the ISBN:nr!", "Error message!", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
            }
            if (!okName)
            {
                MessageBox.Show("You must enter the authors first and last name!", "Error message!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!okTitle)
            {
                MessageBox.Show("You must enter the title of the book!", "Error message!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        /// <summary>
        /// This method is called when the Add button is pressed in the GUI.
        /// If the input is validated to ok, a book is saved in the bookList
        /// through the Addbook method and the GUI is updated. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            // Read book data returns an assigned book object
            Book book = ReadData();
            // Is the input validated?
            if (ValidateInput(book))
            {
                // A book is added to the book list
                myBookManager.AddBook(book);
                // The GUI is updated
                UpdateGUI();
            }
        }

        /// <summary>
        /// This method is called when the Change button is pressed in the GUI.
        /// A new book object is saved with the changed book data at the same index
        /// in the bookList. This is only done if input is validated and if index
        /// is in the range of the bookList. If so, the GUI is updated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Change_Click(object sender, EventArgs e)
        {
            // Read book data returns an assigned book object
            Book book = ReadData();
            // The selected index i the listbox
            int selectedIndex = lbx_BookList.SelectedIndex;

            // Is input validated and an index selected in the listbox?
            if (ValidateInput(book) && selectedIndex >= 0)
            {
                // The book data is changed at index in book list
                myBookManager.ChangeBook(selectedIndex, book);
                // The GUI is updated
                UpdateGUI();
                // The listbox is unselcted
                lbx_BookList.ClearSelected();
                // Add button is enabled
                btn_AddBook.Enabled = true;
            }
        }

        /// <summary>
        /// This method is called when the Delete button is pressed in the GUI.
        /// If a book is selected in the listbox at a specific index, that
        /// book will be deleted in the book list, and the GUI updated. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // The selected index i the listbox
            int selectedIndex = lbx_BookList.SelectedIndex;

            // Is a book in the listbox selected?
            if (selectedIndex >= 0)
            {
                // A book at index is deleted in book list
                myBookManager.DeleteBook(selectedIndex);
                // The GUI is updated
                UpdateGUI();
                // The listbox is unselected
                lbx_BookList.ClearSelected();
                // The add button is enabled
                btn_AddBook.Enabled = true;
            }
        }

        /// <summary>
        /// This method is called when the Unselect button is pressed in the GUI.
        /// The listbox control is unselected and the GUI is updated. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Unselect_Click(object sender, EventArgs e)
        {
            // The selected index in the listbox
            int selectedIndex = lbx_BookList.SelectedIndex;

            // Is the listbox is selected ?
            if (selectedIndex >= 0)
            {
                // The listbox is unselected
                lbx_BookList.ClearSelected();
                // The add button is enabled
                btn_AddBook.Enabled = true;
                // The GUI is updated
                UpdateGUI();
            }
        }

        /// <summary>
        /// This method is called when index of the listbox is changed.
        /// Then the GUI is filled with the book data at that index,
        /// and some button controls are enabled and disabled. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbx_BookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The selected index in the listbox
            int selectedIndex = lbx_BookList.SelectedIndex;

            // Is the listbox is selected ?
            if (selectedIndex >= 0)
            {
                // The change and delete buttons are enabled
                btn_Change.Enabled = true;
                btn_Delete.Enabled = true;
                // The add button is disabled
                btn_AddBook.Enabled = false;
                // The controls in the GUI is filled with book data
                // from the selected index
                FillControls(selectedIndex);
            }
        }

        /// <summary>
        /// This metod fills the controls in the GUI with data from a specific index and book
        /// in the book list.
        /// </summary>
        /// <param name="selectedIndex"></param>
        private void FillControls(int selectedIndex)
        {
            tbx_ISBN.Text = myBookManager.GetBook(selectedIndex).ISBN;
            tbx_AuthorFirstName.Text = myBookManager.GetBook(selectedIndex).MyAuthor.FirstName;
            tbx_AuthorLastName.Text = myBookManager.GetBook(selectedIndex).MyAuthor.LastName;
            tbx_Title.Text = myBookManager.GetBook(selectedIndex).MyTitle.MyTitle;
            cbx_BookType.SelectedIndex = (int)myBookManager.GetBook(selectedIndex).MyBookGenre;
            dtp_DateTimePicker.Value = myBookManager.GetBook(selectedIndex).ReturnDate;
        }
    }
}

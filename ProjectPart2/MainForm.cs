// MainForm.cs
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
    /// This class saves and presents information of book lenders in a
    /// book lender list as part of a GUI. It presents lender id, full name,
    /// next return date, time late or left to return date, mobile phone
    /// number and private email. It uses server classes to read this information,
    /// which can be sorted by the lenders id number, name or return date. Lenders
    /// can be added, edited or deleted.
    /// </summary>
    public partial class MainForm : Form
    {
        private BookLenderManager bookLenderManager;    // Declares an instance variable of the BookLenderManager class

        /// <summary>
        /// The default constructor creates an object of the MainForm class.
        /// Initiates the instance variable and the GUI.
        public MainForm()
        {
            InitializeComponent();
            bookLenderManager = new BookLenderManager();
            InitializeGUI();
        }

        /// <summary>
        /// This method initializes the controls in the GUI
        /// </summary>
        private void InitializeGUI()
        {
            // The form gets the name of the program
            this.Text = "Library manager";
            // Updates the GUI
            UpdateGUI();
        }

        /// <summary>
        /// This method updates the controls in the GUI
        /// </summary>
        private void UpdateGUI()
        {
            // Buttons are updated
            ButtonControl2();
            ButtonControl3();
            // The listbox is cleared
            lbx_LenderDetails.Items.Clear();
            // The list of book lenders is loaded in the listbox
            lbx_LenderDetails.Items.AddRange(bookLenderManager.ToStringArray());
        }

        /// <summary>
        /// This method is called when the Add lender button is pressed. A new
        /// object of the BookLenderForm is created, and a new form is opened.
        /// If input is valid, the book lender is added to the book lender list and
        /// the GUI is updated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddLender_Click(object sender, EventArgs e)
        {
            // A new book lender form is created with a title as parameter
            BookLenderForm formLender = new BookLenderForm("Add Book Lender");

            // Is the Ok button pressed in the book lender form and is the input valid ?
            if ((formLender.ShowDialog() == DialogResult.OK) && formLender.ValidateInput()) 
            {
                // The book lender is added to the book lender list
                bookLenderManager.AddBookLender(formLender.MyBookLender);
                // The book lender list is sorted by book lender ID 
                bookLenderManager.SortListByID();
                // Updates the GUI
                UpdateGUI();
            }
        }

        /// <summary>
        /// The method is called when the View and edit button is pressed in the GUI.
        /// It gives the possiblity to edit the book lender information. 
        /// A book lender in the list have to be selected. The GUI of the server class
        /// is opened and possible changes read. If the input data is valid, the possible
        /// changed lender data is saved at the same index in the book lender list. And the
        /// list is updated in the GUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ViewAndEdit_Click(object sender, EventArgs e)
        {
            // Index of the selected book lender in the list in the GUI
            int selectedIndex = lbx_LenderDetails.SelectedIndex;

            // Is a book lender selected in the listbox ?
            if (selectedIndex >= 0)
            {
                // A new object of the BookLenderForm class is created with a title and saved book lender at selected index as parameters
                BookLenderForm savedFormLender = new BookLenderForm("View And Edit", bookLenderManager.GetBookLenderAtIndex(selectedIndex));

                // Is the OK button pressed and valid book lender input from the server class form ?
                if ((savedFormLender.ShowDialog() == DialogResult.OK) && savedFormLender.ValidateInput())
                {
                    // Changed book lender data is saved in book lender list at selected index
                    bookLenderManager.ChangeBookLender(selectedIndex, savedFormLender.MyBookLender);
                    // The book lender list is sorted by book lender ID 
                    bookLenderManager.SortListByID();
                    // The GUI is updated
                    UpdateGUI();
                }
            }
        }

        /// <summary>
        /// The method is called when the Delete lender button is pressed in the GUI.
        /// If a book lender is selected in the listbox, it will be deleted in the
        /// book lender list at that index. The GUI is then updated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteLender_Click(object sender, EventArgs e)
        {
            // Index of the selected book lender in the list in the GUI
            int selectedIndex = lbx_LenderDetails.SelectedIndex;

            // Is a book lender selected in the listbox ?
            if (selectedIndex >= 0)
            {
                // The book lender is deleted at index in the book lender list
                bookLenderManager.DeleteBookLender(selectedIndex);
                // The GUI is updated
                UpdateGUI();
            }

        }

        /// <summary>
        /// The method is called when the Sort ID button is pressed in the GUI.
        /// The book lender list is sorted by book lender ID and the GUI is updated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SortID_Click(object sender, EventArgs e)
        {
            // The list is sorted
            bookLenderManager.SortListByID();
            // The GUI is updated
            UpdateGUI();
        }

        /// <summary>
        /// The method is called when the Sort name button is pressed in the GUI.
        /// The book lender list is sorted by book lenders last name and the GUI is updated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SortName_Click(object sender, EventArgs e)
        {
            // The list is sorted
            bookLenderManager.SortListByName();
            // The GUI is updated
            UpdateGUI();
        }

        /// <summary>
        /// The method is called when the Sort return date button is pressed in the GUI.
        /// The book lender list is sorted by book lenders next return date and the GUI is updated. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SortReturnDate_Click(object sender, EventArgs e)
        {
            // The list is sorted
            bookLenderManager.SortListByReturnDate();
            // The GUI is updated
            UpdateGUI();
        }

        /// <summary>
        /// The method is called when the selected index in the listbox is changed.
        /// If a book lender is selected in the listbox, the View and Edit button and
        /// the Delete Lender button are enabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbx_LenderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl1();   
        }

        /// <summary>
        /// This method enables the View and Edit button and
        /// the Delete Lender button in the GUI.
        /// </summary>
        private void ButtonControl1()
        {
            btn_ViewAndEdit.Enabled = true;
            btn_DeleteLender.Enabled = true;
        }

        /// <summary>
        /// This method disables the View and Edit button and
        /// the Delete Lender button in the GUI.
        /// </summary>
        private void ButtonControl2()
        {
            btn_ViewAndEdit.Enabled = false;
            btn_DeleteLender.Enabled = false;
        }

        /// <summary>
        /// This method determines if the Sort ID, Sort Name and Sort Return Date
        /// buttons are enabled or disabled in the GUI. If there are book lenders
        /// in the book lender list, the buttons are enabled, else disabled.
        /// </summary>
        private void ButtonControl3()
        {
            // Are there any book lenders in the list ?
            if (bookLenderManager.Count > 0)
            {
                btn_SortID.Enabled = true;
                btn_SortName.Enabled = true;
                btn_SortReturnDate.Enabled = true;
            }
            else
            {
                btn_SortID.Enabled = false;
                btn_SortName.Enabled = false;
                btn_SortReturnDate.Enabled = false;
            }
        }

        /// <summary>
        /// This method is called when the MainForm is about to be closed.
        /// Depending on the boolean value from the ResultFromQuitDialog
        /// method, the form can be closed or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !ResultFromQuitDialog(); // If e.Cancel = false, the form is closed
        }

        /// <summary>
        /// This method shows a messagebox, with the question if to close the program or not?
        /// The mesagebox has one Yes and one No button. If Yes is pressed the program exits,
        /// and method return true, if No it stays open and method return false. 
        /// </summary>
        /// <returns>A boolean value</returns>
        private bool ResultFromQuitDialog()
        {
            bool exit = false;
            // Is the Yes button pressed?
            if (MessageBox.Show("Exit program?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // The program will close
                exit = true;
            }
            // Returns true or false
            return exit;
        }

        /// <summary>
        /// This method closes the program when the exit submenu
        /// is clicked in the MenuStrip control in the GUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_File_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This method is called when keys are pressed in the program.
        /// If the "control" and "F4" keys is pressed at same time the
        /// program exits. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Are "control" and "F4" keys pressed?
            if (e.Control && e.KeyCode.ToString() == "F4")
            {
                Close();
            }
        }

        /// <summary>
        /// This method opens a form showing information
        /// about the program, as program name, version, 
        /// copyrights, name of the company and a 
        /// description of the program. This i done when
        /// the About submenu is clicked in the MenuStrip
        /// control in the GUI. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutBox_Help_Click(object sender, EventArgs e)
        {
            // A new form is created
            AboutBox aboutBox = new AboutBox();
            // The form is opened with the information
            aboutBox.ShowDialog();
        }
    }
}

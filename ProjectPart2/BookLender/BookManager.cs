// BookManager.cs
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
    /// An object of this class holds data, a list of the Book class.
    /// This class contains a list of books.
    /// </summary>
    public class BookManager
    {
        private List<Book> bookList;    // Declares an instance variable as a list of the Book class

        /// <summary>
        /// The default constructor, creates a BookManager object,
        /// and initiates the instance variable.
        /// <summary>
        public BookManager()
        {
            bookList = new List<Book>();   
        }

        /// <summary>
        /// This property gets or sets the instance variable bookList
        /// </summary>
        public List<Book> MyBookList
        {
            get
            {
                return bookList;
            }
            set
            {
                // Is the value not null ?
                if (value != null)
                {
                    bookList = value;
                }
            }
        }

        /// <summary>
        /// This property gets lenght of instance variable bookList
        /// </summary>
        public int Count
        {
            get { return bookList.Count(); }
        }

        /// <summary>
        /// The method validates if index as parameter
        /// is in the range of the task list. It returns
        /// true if so, else false.
        /// <param name="index">The integer value of index</param>
        /// <returns>A boolean value</returns>
        public bool ValidateIndex(int index)
        {
            return (index >= 0) && (index < Count);
        }

        /// <summary>
        /// The method adds a book to the instance variable
        /// bookList. If the add is successful method
        /// return true, else false. 
        /// </summary>
        /// <param name="book">book as a Book object</param>
        /// <returns>A boolena value</returns>
        public bool AddBook(Book book)
        {
            bool addOk = false;
            // Is the object not null?
            if (book != null)
            {
                // A book is added to the list
                bookList.Add(book);
                // The add is successful
                addOk = true;
            }
            // Returns true or false
            return addOk;
        }

        /// <summary>
        /// This method deletes a book in the instance
        /// variable bookList at a specific index. If
        /// successful the method returns true, else false. 
        /// </summary>
        /// <param name="index">index as an integer</param>
        /// <returns>A boolean value</returns>
        public bool DeleteBook(int index)
        {
            bool deleteOk = false;

            // Is the index within the range of the list?
            if (ValidateIndex(index))
            {
                // The book at index is deleted in the list
                bookList.RemoveAt(index);
                // Delete is successful
                deleteOk = true;
            }
            // Returns true or false
            return deleteOk;
        }

        /// <summary>
        /// This method changes book data in the instance variable
        /// bookList at a specific index, If it's successful the
        /// method returns true, else false. 
        /// </summary>
        /// <param name="index">index as an integer</param>
        /// <param name="newBook">newBook as a Book object</param>
        /// <returns></returns>
        public bool ChangeBook(int index, Book newBook)
        {
            bool changeOk = false;

            // Is object is not null and index within range of list?
            if (ValidateIndex(index) && (newBook != null))
            {
                // Deletes old object
                bookList[index] = null;
                // Assigns changed object at index in list
                bookList[index] = newBook;
                // Change successful
                changeOk = true;
            }
            // Returns true or false
            return changeOk;
        }

        /// <summary>
        /// This method gets a book object in the instance variable
        /// bookList at a specific index. Method returns the book object. 
        /// </summary>
        /// <param name="index">index as an interger</param>
        /// <returns>A book object</returns>
        public Book GetBook(int index)
        {
            // Is index within the range of the list?
            if (ValidateIndex(index))
            {
                // Returns the Book object att index
                return bookList[index];
            }
            // Index not within range, null is returned
            return null;
        }

        /// <summary>
        /// This method gets the ToString info from each book object in the
        /// instance variable bookList and assigns it to a new 
        /// array of the same lenght. Method returns that array.
        /// </summary>
        /// <returns>A string array</returns>
        public string[] ToStringArray()
        {
            // The methods ConvertAll and ToArray is used  
            return bookList.ConvertAll(x => x.ToString()).ToArray();
        }

        /// <summary>
        /// This method picks the return date which is closest in time,
        /// for all the book in a lenders list of borrowed books. Then
        /// it calculates how many days it is left to that date. If the
        /// it's a negative number, the book hasn't been returned yet.
        /// And its refered as late in the string returned. A lender
        /// with no books will get an empty string returned.
        /// </summary>
        /// <returns>A string</returns>
        public string DaysToReturnBook()
        {
            // Does the lender have any borrowed books ?
            if (Count > 0)
            {
                int DiffDays = 0;
                // A high value, that will garantee that next value 
                // will be the smallest in comparison to it.
                int minDiffDays = 9999;

                // Iterates through the booklist
                for (int i = 0; i < Count; i++)
                {
                    // Calculates how many days it is to the return date
                    DiffDays = (int)(bookList[i].ReturnDate - DateTime.Now).TotalDays;
                    // The least number of days is saved
                    minDiffDays = Math.Min(minDiffDays, DiffDays);
                }

                // Are there any days left to the return date ?
                if (minDiffDays >= 0)
                {
                    // The DateTime class has limitations and is compensated + 1
                    // Returns the number of days left as a string
                    return (minDiffDays + 1) + " days left";  
                }
                else // If not, then lender is late
                {
                    // Returns the number of days late as a string
                    return (minDiffDays * -1) + " days late";
                }
            }
            else // The lender doesn't have any borrowed books
            {
                return string.Empty; 
            }
        }

        /// <summary>
        /// This method picks the return date which is closest in time to today,
        /// for all the book in a lenders list of borrowed books. Then the date
        /// is returned.
        /// </summary>
        /// <returns>A DateTime object</returns>
        public DateTime NextReturnDate()
        {
            int DiffDays = 0;
            // A high value, that will garantee that next value 
            // will be the smallest in comparison to it.
            int minDiffDays = 9999;
            int minIndex = 0;

            // Does the lender have any borrowed books ?
            if (Count > 0)
            {
                // Iterates through the booklist
                for (int i = 0; i < Count; i++)
                {
                    // Calculates how many days it is to the return date
                    DiffDays = (int)(bookList[i].ReturnDate - DateTime.Now).TotalDays;
                    // Is that number less than the least of all previos tested?
                    if (DiffDays < minDiffDays)
                    {
                        // The index of list of that number is saved
                        minIndex = i;
                    }
                    // The smallest number of days is saved
                    minDiffDays = Math.Min(minDiffDays, DiffDays);
                }
                // The date of the least number of days to the return date is returned
                return bookList[minIndex].ReturnDate;
            }
            else // The lender hasn't borrowed any books, and is assigned a max value, since it's going to be sorted later.
            {    // I want books with lowest real return date to be sorted above in list, those with a not real date gets max value.
                return DateTime.MaxValue; 
            }
        }

        /// <summary>
        /// This method displays the values of the instance
        /// variables of this class, as a formatted string.
        /// </summary>
        /// <returns>A formatted string</returns>
        public override string ToString()
        {
            string strOut = string.Format("The number of books in the list: {0} ", Count);
            return strOut;
        }
    }
}

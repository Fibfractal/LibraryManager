// Book.cs
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
    /// An object of this class holds data, as ISBN number, author name, book title,
    /// book genre and the return date of a book.
    /// </summary>
    public class Book
    {
        private string _ISBN;           // Declares a string instance variable
        private Author author;          // Declares an instance variable of the Author class
        private Title title;            // Declares an instance variable of the Title class
        private BookGenre bookGenre;    // Declares an instance variable of the enum BookGenre
        private DateTime returnDate;    // Declares an instance variable of the struct DateTime

        /// <summary>
        /// The default constructor, calls the constructor with five parameters
        /// in this class. 
        /// </summary>
        public Book() : this(string.Empty,new Author(),new Title(), new BookGenre(), new DateTime())
        {
        }

        /// <summary>
        /// A constructor, creates an object of the
        /// Book class, and initiates it's instance
        /// variables with argument values. It has 
        /// five parameters. 
        /// </summary>
        /// <param name="myISBN">myISBN as string</param>
        /// <param name="myAuthor">myAuthor as an Author object</param>
        /// <param name="myTitle">myTitle as an Title object</param>
        /// <param name="myBookGenre">myBookGenre as BookGenre</param>
        /// <param name="myReturnDate">myReturnDate as DateTime</param>
        public Book(string myISBN, Author myAuthor, Title myTitle, BookGenre myBookGenre, DateTime myReturnDate)
        {
            _ISBN = myISBN;
            author = myAuthor;
            title = myTitle;
            bookGenre = myBookGenre;
            returnDate = myReturnDate;
        }

        /// <summary>
        /// This property gets or sets the instance variable _ISBN 
        /// </summary>
        public string ISBN
        {
            get
            {
                return _ISBN;
            }
            set
            {
                // Is the value not empty?
                if (value != string.Empty)
                {
                    _ISBN = value;
                }
            }
        }

        /// <summary>
        /// This property gets or sets the instance variable author 
        /// </summary>
        public Author MyAuthor
        {
            get
            {
                return author;
            }
            set
            {
                // Is the value not null?
                if (value != null)
                {
                    author = value;
                }
            }
        }

        /// <summary>
        /// This property gets or sets the instance variable title 
        /// </summary>
        public Title MyTitle
        {
            get
            {
                return title;
            }
            set
            {
                // Is the value not null?
                if (value != null)
                {
                    title = value;
                }
            }
        }

        /// <summary>
        /// This property gets or sets the instance variable bookGenre 
        /// </summary>
        public BookGenre MyBookGenre
        {
            get
            {
                return bookGenre;
            }
            set
            {
                // Is the value >= 0 ?
                if (value >= 0)
                {
                    bookGenre = value;
                }
            }
        }

        /// <summary>
        /// This property gets or sets the instance variable returnDate 
        /// </summary>
        public DateTime ReturnDate
        {
            get
            {
                return returnDate;
            }
            set
            {
                // Is the value not null?
                if (value != null)
                {
                    returnDate = value;
                }
            }
        }

        /// <summary>
        /// The method converts the instance variable
        /// bookGenre to a string, and "_" is replaced
        /// with " " in the string.  
        /// </summary>
        /// <returns>A string</returns>
        private string GetBookGenreString()
        {
            // The Replace method is used to change the string
            return bookGenre.ToString().Replace("_", " ");
        }

        /// <summary>
        /// The method validates the instance variable
        /// _ISBN. If it's not empty, the method 
        /// returns true, else false.
        /// </summary>
        /// <returns>A boolean value</returns>
        public bool ValidateInput()
        {
            return _ISBN != string.Empty;
        }

        /// <summary>
        /// This method displays the values of the instance
        /// variables of this class, as a formatted string.
        /// </summary>
        /// <returns>A formatted string</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0,-22} {1} {2} {3,-27} {4,-20}",
                _ISBN, author.ToString(), title.ToString(), GetBookGenreString(), returnDate.ToShortDateString());
            return strOut;
        }

    }
}

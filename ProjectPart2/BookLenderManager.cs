// BookLenderManager.cs
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
    /// An object of this class can hold data as a list of the BookLender class. 
    /// This class contains a list of book lenders.
    /// </summary>
    public class BookLenderManager
    {
        private List<BookLender> bookLenderList; // Declares an instance variable of the BookLenderManager class, a list of book lenders

        /// <summary>
        /// The default constructor, creates a BookLenderManager object,
        /// and initiates the instance variable.
        /// <summary>
        public BookLenderManager()
        {
            bookLenderList = new List<BookLender>();
        }

        /// <summary>
        /// This property gets the lenght of instance variable bookLenderList
        /// </summary>
        public int Count
        {
            get
            {
                return bookLenderList.Count;
            }
        }

        /// <summary>
        /// This property calculates a unique customer ID
        /// and returns the value.It finds the highest value
        /// of the customer id and looks for if any former 
        /// customer id:s with lower values has been deleted.
        /// If so will the the one with lowest value be 
        /// reused as a new id. If no lower is found, a new
        /// id higher then the highest is created. The id
        /// starts from 100.
        /// </summary>
        public int GetNewId
        {
            get
            {
                int max = -1;

                // Iterate through the list to find the highest value of id
                for (int i = 0; i < Count; i++)
                {
                    // 
                    int idList = bookLenderList[i].LenderID;
                    // The highest id value is stored
                    max = Math.Max(max, idList);
                }

                // Iterate and looks for unique id:s between 100 and the maximum id used at 
                // present.
                for (int i = 100; i < max; i++)
                {
                    // Every iteration a possible unique id is true
                    bool uniqueNbr = true;

                    // Every id number "i" is checked in the customer list to see if it's unique
                    // , that is not used and lower than the highest at present.
                    for (int j = 0; j < Count; j++)
                    {
                        // 
                        int idList2 = bookLenderList[j].LenderID;

                        // Is the id found in list, and not unique?
                        if (i == idList2)
                        {
                            // Id not unique
                            uniqueNbr = false;
                        }
                    }

                    // Is this id unique, after iteration through the list?
                    if (uniqueNbr)
                    {
                        // If so, the id will be returned as a new id
                        return i;
                    }

                }

                // No unique id was found between 100 and the present highest id
                // a new highest id will be returned as new id.
                return Count + 100;
            }
        }

        /// <summary>
        /// The method validates if index as parameter
        /// is in the range of the task list. It returns
        /// true if so, else false.
        /// <param name="index">The integer value of index</param>
        /// <returns>A boolean value</returns>
        public bool ValidateIndex(int index)
        {
            // Uses the method Count to get list lenght
            return (index >= 0) && (index < Count);
        }

        /// <summary>
        /// The method adds a bookLender to the instance variable
        /// bookLenderList. If the add is successful method
        ///  return true, else false. 
        /// </summary>
        /// <param name="bookLender">bookLender as a BookLender object</param>
        /// <returns>A boolean value</returns>
        public bool AddBookLender(BookLender bookLender)
        {
            bool addOk = false;

            // Is the object not null?
            if (bookLender != null)
            {
                // The book lender gets an ID
                bookLender.LenderID = GetNewId;
                // The book lender is added to the list
                bookLenderList.Add(bookLender);
                // The add is successful
                addOk = true;
            }
            // Returns true or false
            return addOk;
        }

        /// <summary>
        /// This method deletes a bookLender in the instance
        /// variable bookLenderList at a specific index. If
        /// successful the method returns true, else false. 
        /// </summary>
        /// <param name="index">An interger as index</param>
        /// <returns>A boolean value</returns>
        public bool DeleteBookLender(int index)
        {
            bool deleteOk = false;

            // Is the index within the range of the list?
            if (ValidateIndex(index))
            {
                // The bookLender at index is deleted in the list
                bookLenderList.RemoveAt(index);
                // Delete is successful
                deleteOk = true;
            }
            // Returns true or false
            return deleteOk;
        }

        /// <summary>
        /// This method changes book lender data in the instance variable
        /// bookLenderList at a specific index, If it's successful the
        /// method returns true, else false. 
        /// </summary>
        /// <param name="index">An interger as index</param>
        /// <param name="newBookLender">newBookLender as a BookLender object</param>
        /// <returns>A boolean value</returns>
        public bool ChangeBookLender(int index, BookLender newBookLender)
        {
            bool changeOk = false;

            // Is object is not null and index within range of list?
            if (ValidateIndex(index) && (newBookLender != null))
            {
                // Deletes old object
                bookLenderList[index] = null;
                // Assigns changed object at index in list
                bookLenderList[index] = newBookLender;
                // Change successful
                changeOk = true;
            }
            // Returns true or false
            return changeOk;
        }

        /// <summary>
        /// This method gets a book lender object in the instance variable
        /// bookLenderList at a specific index. Method returns the book lender object. 
        /// </summary>
        /// <param name="index">An integer as index</param>
        /// <returns>An object of the BookLender class</returns>
        public BookLender GetBookLenderAtIndex(int index)
        {
            // Is index within the range of the list ?
            if (ValidateIndex(index))
            {
                // Returns the book lender object at index
                return bookLenderList[index];
            }
            // Index not within range, null is returned
            return null;
        }

        /// <summary>
        /// This method gets the ToString info from each book lender object in the
        /// instance variable bookLenderList and assigns it to a new 
        /// array of the same lenght. Method returns that array.
        /// </summary>
        /// <returns>A string array</returns>
        public string[] ToStringArray()
        {
            // The methods ConvertAll and ToArray is used  
            return bookLenderList.ConvertAll(x => x.ToString()).ToArray();
        }

        /// <summary>
        /// This method sorts the book lender list by book lender ID.
        /// From lowest to highest value.
        /// </summary>
        public void SortListByID()
        {
            bookLenderList.Sort((x, y) => x.LenderID.CompareTo(y.LenderID));
        }

        /// <summary>
        /// This method sorts the book lender list by the next return date.
        /// From lowest to highest value. Late is lowest, no books is highest.
        /// </summary>
        public void SortListByReturnDate()
        {
            bookLenderList.Sort((x, y) => x.GetNextReturnDate().CompareTo(y.GetNextReturnDate()));
        }

        /// <summary>
        /// This method sorts the book lender list by the first letter in the last name.
        /// From a to z.
        /// </summary>
        public void SortListByName()
        {
            bookLenderList.Sort((x, y) => x.FullName.CompareTo(y.FullName));
        }

        /// <summary>
        /// This method displays the values of the instance
        /// variables of this class, as a formatted string.
        /// </summary>
        /// <returns>A formatted string</returns>
        public override string ToString()
        {
            string strOut = string.Format("The number of book lenders in the list: {0} ", Count);
            return strOut;
        }
    }
}

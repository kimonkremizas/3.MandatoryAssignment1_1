using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{   
    /// <summary>
    /// Book class with title, author, pageNumber and isbn13 properties.
    /// </summary>
    public class Book
    {
        private string _title;
        private int _pageNumber;
        private string _isbn13;

        /// <summary>
        /// Default empty constructor
        /// </summary>
        public Book() { }

        /// <summary>
        /// This constructor takes 4 properties as arguments.
        /// </summary>
        /// <param name="title">The book title (string with 2 or more characters)</param>
        /// <param name="author">The book author (string).</param>
        /// <param name="pageNumber">The book number of pages (int between 11 and 1000).</param>
        /// <param name="isbn13">The book ISBN13 (string with exactly 13 characters).</param>
        public Book(string title, string author, int pageNumber, string isbn13)
        {
            Title = title;
            Author = author;
            PageNumber = pageNumber;
            Isbn13 = isbn13;
        }
        
        /// <summary>
        /// Title property. Must contain at least 2 characters. (type:string)
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Title must contain at least 2 characters.");
                }
                _title = value;
            }
        }

        /// <summary>
        /// Author property. No constraints. (type:string)
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Page Number property. Must be a number between 11 and 1000 inclusive. (type:int)
        /// </summary>
        public int PageNumber
        {
            get { return _pageNumber; }
            set
            {
                if (value <= 10 || value > 1000)
                {
                    throw new ArgumentException("Page Number must be equal to a number from 11 to 1000.");
                }
                _pageNumber = value;
            }
        }

        /// <summary>
        /// ISBN13 property. Must contain exactly 13 characters. (type:string)
        /// </summary>
        public string Isbn13
        {
            get { return _isbn13; }
            set
            {
                if (value.Length != 13)
                {
                    throw new ArgumentException("ISBN must contain exactly 13 characters.");
                }
                _isbn13 = value;
            }
        }
    }
}

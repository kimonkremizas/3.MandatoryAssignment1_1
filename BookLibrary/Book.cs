using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{
    public class Book
    {
        private string _title;
        private int _pageNumber;
        private string _isbn13;

        //Default constructor
        public Book() { }

        //Constructor
        public Book(string title, string author, int pageNumber, string isbn13)
        {
            Title = title;
            Author = author;
            PageNumber = pageNumber;
            Isbn13 = isbn13;
        }


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

        public string Author { get; set; }

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

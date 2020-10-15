using System;
using BookLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookLibraryUnitTest
{
    [TestClass]
    public class BookTest
    {
        [DataTestMethod]
        [DataRow("It")]
        [DataRow("The Shining")]
        public void TestValidTitle(string theTitle)
        {
            //Arrange
            Book theBook = new Book();
            string expected = theTitle;

            //Act
            theBook.Title = theTitle;
            string actual = theBook.Title;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [DataTestMethod]
        [DataRow("Ù")]
        [DataRow("")]
        [ExpectedException(typeof(ArgumentException))]
        public void TesttInvalidTitle(string theTitle)
        {
            //Arrange
            Book theBook = new Book();

            //Act
            theBook.Title = theTitle;

            //Assert
            Assert.Fail();
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("Stephen King")]
        [DataRow("Stephen King70!")]
        public void TestValidAuthor(string theAuthor)
        {
            //Arrange
            Book theBook = new Book();
            string expected = theAuthor;

            //Act
            theBook.Author = theAuthor;
            string actual = theBook.Author;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(11)]
        [DataRow(500)]
        [DataRow(1000)]
        public void TestValidPageNumber(int thePageNumber)
        {
            //Arrange
            Book theBook = new Book();
            int expected = thePageNumber;

            //Act
            theBook.PageNumber = thePageNumber;
            int actual = theBook.PageNumber;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow(0)]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(1001)]
        [DataRow(9999999999)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidPageNumber(int thePageNumber)
        {
            //Arrange
            Book theBook = new Book();

            //Act
            theBook.PageNumber = thePageNumber;

            //Assert
            Assert.Fail();
        }

        [DataTestMethod]
        [DataRow("1111111111113")]
        [DataRow("thirteenchars")]
        [DataRow("13characters!")]
        public void TestValidIsbn13(string theIsbn)
        {
            //Arrange
            Book theBook = new Book();
            string expected = theIsbn;

            //Act
            theBook.Isbn13 = theIsbn;
            string actual = theBook.Isbn13;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1111111111113)]
        [DataRow("")]
        [DataRow("1")]
        [DataRow("55555")]
        [DataRow("999999999")]
        [DataRow("121212121212")]
        [DataRow("14141414141414")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidIsbn13(string theIsbn)
        {
            //Arrange
            Book theBook = new Book();

            //Act
            theBook.Isbn13 = theIsbn;

            //Assert
            Assert.Fail();
        }
    }
}

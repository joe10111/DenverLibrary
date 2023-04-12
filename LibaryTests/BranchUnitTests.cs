using System;
using DenverLibrary;

namespace LibaryTests
{
	public class BranchUnitTests
	{
        [Fact] // Tests for Branch Constructor
        public void Test_BranchConstructor()
        {
            Branch branch1 = new Branch("branchOne");

            Assert.Equal("branchOne", branch1.Name);

            Assert.Equal(new List<Book> { }, branch1.Books);

        }

        [Fact]
        public void Test_AddBook()
        {
            Book book1 = new Book("nameOfBook", "Joe");
            Branch branch1 = new Branch("branchOne");

            branch1.AddBook(book1);

            Assert.Equal(new List<Book> { book1 }, branch1.Books);
        }

        [Fact]
        public void Test_AllAuthors()
        {
            Book book1 = new Book("nameOfBook", "Joe");
            Book book2 = new Book("nameOfBookTheBetterOne", "Ahnika");
            Branch branch1 = new Branch("branchOne");

            branch1.AddBook(book1);
            branch1.AddBook(book2);

            Assert.Equal(new List<string> { "Joe", "Ahnika" }, branch1.AllAuthors());
        }
    }
}
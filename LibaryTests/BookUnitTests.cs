using System;
using DenverLibrary;

namespace LibaryTests
{
	public class BookUnitTests
	{
        [Fact] // Tests for Book Constructor
        public void Test_BookConstructor()
        {
            Book book1 = new Book("nameOfBook", "Joe");
            Assert.Equal("nameOfBook", book1.Title);
            Assert.Equal("Joe", book1.Author);
        }
    }
}


using DenverLibrary;

namespace LibaryTests
{
    public class LibraryUnitTests
    {
        [Fact] 
        public void Test_LibraryConstructor()
        {
            Library lib1 = new Library("LibraryOne");

            Assert.Equal("LibraryOne", lib1.Name);

            Assert.Equal(new List<Branch> { }, lib1.Branches);
        }

        [Fact]
        public void Test_AddBranch()
        {
            Library lib1 = new Library("LibraryOne");
            Branch branch1 = new Branch("branchOne");

            lib1.AddBranch(branch1);

            Assert.Equal(new List<Branch> { branch1 }, lib1.Branches);
        }

        [Fact]
        public void Test_AddBranchNames()
        {
            Library lib1 = new Library("LibraryOne");
            Branch branch1 = new Branch("branchOne");
            Branch branch2 = new Branch("branchTwo");
            Branch branch3 = new Branch("branchThree");


            lib1.AddBranch(branch1);
            lib1.AddBranch(branch2);
            lib1.AddBranch(branch3);

            var BranchesInLib1 = new List<string> { "branchOne", "branchTwo", "branchThree" };
            Assert.Equal(BranchesInLib1, lib1.BranchNames());
        }

        [Fact]
        public void Test_AllBooks()
        {
            Library lib1 = new Library("LibraryOne");

            Branch branch1 = new Branch("branchOne");
            Branch branch2 = new Branch("branchTwo");

            Book book1 = new Book("nameOfBook", "Joe");
            Book book2 = new Book("nameOfBookTheBetterOne", "Ahnika");
            Book book3 = new Book("Why Macs suck, and windows rules!", "Joe 2018");
            Book book4 = new Book("VS on mac > VS on Windows", "Joe 2023");

            lib1.AddBranch(branch1);
            lib1.AddBranch(branch2);
           
            branch1.AddBook(book1);
            branch1.AddBook(book2);
            branch2.AddBook(book3);
            branch2.AddBook(book4);

            var expectedBooks = new List<string> { "nameOfBook", "nameOfBookTheBetterOne", "Why Macs suck, and windows rules!", "VS on mac > VS on Windows" };

            Assert.Equal(expectedBooks, lib1.AllBooks());
        }
    }
}
namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Flowers for Algernon", "Novel");

            LibraryUser lu = new LibraryUser();
            lu.BorrowBook(book);
        }
    }
}

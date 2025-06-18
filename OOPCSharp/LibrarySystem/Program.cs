namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "Flowers for Algernon";
            book.ID = 1;

            LibraryUser lu = new LibraryUser();
            lu.BorrowBook(book);
        }
    }
}

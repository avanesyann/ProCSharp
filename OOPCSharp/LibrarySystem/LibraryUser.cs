namespace LibrarySystem
{
    internal class LibraryUser
    {
        public string Name;
        
        public void BorrowBook(Book book)
        {
            Console.WriteLine($"Borrowed - {book.Title}, ID: {book.ID}");
        }
    }
}

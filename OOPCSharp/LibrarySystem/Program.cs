namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("War and Peace", "Leo Tolstoy", 1225));
            books.Add(new Book("To Kill a Mockingbird", "Harper Lee", 336));
            books.Add(new Book("Flowers for Algernon", "Daniel Keyes", 311));

            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title, -25} [{book.Pages, 4}] | {book.Author}");
            }

            Console.WriteLine();
            Console.WriteLine();

            books[1].Borrow();
            books[1].Borrow();
            books[1].Return();
        }
    }
}

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new Book("War and Peace", "Leo Tolstoy", 1225));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 336));
            library.AddBook(new Book("Flowers for Algernon", "Daniel Keyes", 311));
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 180));
            library.AddBook(new Book("Lolita", "Vladimir Nabokov", 336));
            library.AddBook(new Book("The Trial", "Franz Kafka", 336));

            library.DisplayStats();

            library.FindByTitle("War and Peace")?.Borrow();
            library.FindByTitle("Flowers for Algernon")?.Borrow();

            library.DisplayStats();

            library.FindByAuthor("Leo Tolstoy");
        }
    }
}

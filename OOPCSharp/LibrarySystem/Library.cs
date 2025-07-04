﻿namespace LibrarySystem
{
    class Library
    {
        private List<Book> _books = new List<Book>();
        public void AddBook(Book book) => _books.Add(book);
        public void DisplayStats()
        {
            Console.WriteLine();
            Console.WriteLine($"There are {TotalBooks} total books in the library.");
            Console.WriteLine($"{AvailableBooks} of them are available.");
            Console.WriteLine($"{BorrowedBooks} of them are currently borrowed.");
            Console.WriteLine();
        }
        public Book? FindByTitle(string title) 
            => _books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        public void FindByAuthor(string author)
        {
            Console.WriteLine("Books by {0}:", author);
            foreach (Book book in _books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine(book.Title);
            }
            Console.WriteLine();
        }

        public int TotalBooks => _books.Count;
        public int AvailableBooks => _books.Count(b => b.IsAvailable);
        public int BorrowedBooks => _books.Count(b => !b.IsAvailable);
    }
}

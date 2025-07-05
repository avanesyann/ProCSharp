namespace LibrarySystem
{
    internal class Book
    {
        private string _title;
        private string _author;
        public bool IsAvailable { get; private set; } = true;
        private int _pages;
        private DateTime BorrowedOn { get; set; }
        private readonly int ReturnDeadline = 1;

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Couldn't assign a title.");
                else
                    _title = value;
            }
        }
        public string Author
        {
            get => _author;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Couldn't assign an author.");
                else
                    _author = value;
            }
        }
        public int Pages
        {
            get => _pages;
            set
            {
                if (value < 0)
                    Console.WriteLine("Page count can't be negative.");
                else
                    _pages = value;
            }
        }


        public void Borrow()
        {
            if (IsAvailable)
            {
                Console.WriteLine($"You borrowed: {Title} by {Author}, happy reading!");
                IsAvailable = false;
                BorrowedOn = DateTime.Now;
            }
            else
            {
                Console.WriteLine($"The book is not available.");
            }
        }
        public void Return()
        {
            if (!IsAvailable)
            {
                
                if ((DateTime.Now.Year - BorrowedOn.Year) > ReturnDeadline)
                    Console.Write("You returned late: ");
                else
                    Console.Write("You returned on time: ");

                Console.Write($"{Title} by {Author}, hope you liked it!");
                IsAvailable = true;
            }
            else
            {
                Console.WriteLine($"The book is not borrowed.");
            }
        }
    }
}

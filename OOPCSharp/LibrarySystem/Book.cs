namespace LibrarySystem
{
    internal class Book
    {
        public string Title;
        private string _secretNote;
        internal int ID;
        protected string Genre;

        public Book(string title, string genre)
        {
            Title = title;
            Genre = genre;
        }
    }
    internal class PremiumBook : Book
    {
        public PremiumBook(string title, string genre) : base(title, genre) { }
        public void RevealGenre()
        {
            Console.WriteLine($"{Title}'s genre is {Genre}");
        }
    }
}

namespace Foundation1.Classes
{
    // Define Class
    class Comment
    {
        // Attributes
        private string _author;
        private string _text;

        // Constructors
        public Comment(string author, string text)
        {
            _author = author;
            _text = text;
        }

        // Methods
        public void Display()
        {
            Console.WriteLine($">> From {_author}: \"{_text}\"");
        }
    }
}
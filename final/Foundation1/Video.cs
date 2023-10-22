namespace Foundation1.Classes
{
    // Define Class
    class Video
    {
        // Attributes
        private string _title;
        private string _author;
        private int _length;
        private List<Comment> _comments = new List<Comment>();

        // Constructors
        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
        }

        // Methods
        private int GetNumComments()
        {
            return _comments.Count();
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public void Display()
        {
            Console.WriteLine(
                $"\"{_title}\" uploaded by {_author}, {_length} seconds long, {GetNumComments()} comments"
            );
            foreach (Comment comment in _comments)
            {
                comment.Display();
            }
            Console.WriteLine();
        }
    }
}
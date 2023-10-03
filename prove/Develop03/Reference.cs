
    
    public class Reference
    {
        
        private string _book;
        private int _chapter;
        private List<int> _verses = new List<int>();

        
        public Reference(string inputString)
        {
           
            string[] splits = inputString.Split(" ");
            
            string numbers = splits[^1];
            
            string[] removed = splits.SkipLast(1).ToArray();
            
            _book = string.Join(" ", removed);
            
            string[] splits2 = numbers.Split(":");
            
            _chapter = int.Parse(splits2[0]);
            
            string verses = splits2[^1];
            
            if (verses.Contains("-"))
            {
                string[] versesSplit = verses.Split("-");
                for (int i=0; i<versesSplit.Count(); i++)
                {
                    _verses.Add(int.Parse(versesSplit[i]));
                }
            }
            else if (verses.Contains(","))
            {
                string[] versesSplit = verses.Split(",");
                for (int i=0; i<versesSplit.Count(); i++)
                {
                    _verses.Add(int.Parse(versesSplit[i]));
                }
            }
            else
            {
                _verses.Add(int.Parse(verses));
            }            

        }

        
        public void DisplayReference()
        {
            string versePrinter;
            if (_verses[0] == _verses[^1])
            {
                versePrinter = $"{_verses[0]}";
            }
            else 
            {
                versePrinter = $"{_verses[0]}-{_verses[^1]}";
            }
            Console.Write($"{_book} {_chapter}:{versePrinter} - ");
        }
    }

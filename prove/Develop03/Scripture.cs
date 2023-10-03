

    public class Scripture
    {
        private List<Word> _wordList = new List<Word>();
        private Reference _reference;

        public Scripture() { }

        public Scripture(string inputString)
        {
            List<string> divided = new List<string>(inputString.Split(" - "));
            _reference = new Reference(divided[0]);
            divided.RemoveAt(0);
            string text = string.Join(" - ", divided);
            string[] wordsList = text.Split(" ");

            foreach (string wordIt in wordsList)
            {
                Word word = new Word(wordIt);
                _wordList.Add(word);
            }
        }

        
        public List<Word> GetwordList()
        {
            return _wordList;
        }

        public Reference GetReference()
        {
            return _reference;
        }

        
        public bool HideRandomWords(int numTimes)
        {
            Random tRex = new Random();
            bool hidEnough;
            bool noneLeft = true;
            for (int i = 0; i < numTimes; i++)
            {
                hidEnough = false;
                noneLeft = true;
                while (!hidEnough)
                {
                    hidEnough = _wordList[tRex.Next(_wordList.Count)].HideWord();
                }
                foreach (Word wordIt in _wordList)
                {
                    if (!wordIt.GetIsHidden())
                    {
                        noneLeft = false;
                    }
                }
                if (noneLeft)
                {
                    return noneLeft;
                }
            }
            return noneLeft;
        }

        public void DisplayScripture()
        {
            Console.Clear();
            _reference.DisplayReference();
            foreach (var word in _wordList)
            {
                Console.Write(word.GetSingleWord() + " ");
            }
            Console.WriteLine();
        }
    }

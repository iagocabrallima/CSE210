
    public class Word
    {

        private string _singleWord;
        private bool _isHidden = false;

        public Word(string singleWord)
        {
            _singleWord = singleWord;
        }

        public string GetSingleWord()
        {
            return _singleWord;
        }

        public bool GetIsHidden()
        {
            return _isHidden;
        }

        public bool HideWord()
        {
            if (!_isHidden)
            {
                string newWord = "";
                foreach (var letter in _singleWord)
                {
                    if (char.IsLetter(letter))
                    {
                        newWord += "_";
                    }
                    else
                    {
                        newWord += letter;
                    }
                }
                _singleWord = newWord;
                return _isHidden = true;
            }
            else
            {
                return false;
            }
        }
    }

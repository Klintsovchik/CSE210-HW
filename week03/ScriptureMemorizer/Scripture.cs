public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {   
        _reference = reference;
        string[] allWords = text.Split(' ');
        _words = new List<Word>();
        foreach (string word in allWords)
        {
            Word word1 = new Word(word);
            _words.Add(word1);
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if(word.IsHidden() == false)
            {
                return false;
            }

        }
        return true;
    }
    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string text = string.Join(" ", _words.Select(w => w.GetRenderedText()));
        return $"{reference} {text}";
    }
    public void HideRandomWords()
    {
        //Make it hide only words that are not hidden yet
        List<Word> visibleWords = new List<Word>();
        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                visibleWords.Add(word);
            }
        }
        if (visibleWords.Count == 0)
        {
            return;
        }

        Random random = new Random();
        int index = random.Next(0, visibleWords.Count);
        visibleWords[index].Hide();
    }


}
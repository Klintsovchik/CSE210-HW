
public class Word
{
    // had to be private
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    // A method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // A method that decides what to return: the word or underscore
    public string GetRenderedText()
    {
        if (_isHidden == true)
        {
            int count = _text.Length;
            return new string('_',count);
        }
        else
        {
            return _text;
        }
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

}
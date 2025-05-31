public class Word
{
    private string _text;
    private bool _isHidden;
//makes sure that the verse starts out fully visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false; 
    }
// hides each word
    public void Hide()
    {
        _isHidden = true;
    }
// checks if each word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

// prints out the verse with differing amounts of words being hidden. also makes sure that the __ match the length of the words
    public string GetFinalText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}

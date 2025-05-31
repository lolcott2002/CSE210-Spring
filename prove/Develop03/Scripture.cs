public class Scripture
{
    private ScriptureReference _reference;
//made a list that will hold my individual words
    private List<Word> _words;
//glues a scripture reference and text together
    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // splits my verse into individual words so that they can be hidden. also accounts for punctuation.
        string[] individualWords = text.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string individualWord in individualWords)
        {
            _words.Add(new Word(individualWord));
        }
    }

// function that gives what the scripture looks like when displayed
    public string TextToDisplay()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetFinalText() + " ";
        }
        return $"{_reference.GetFinalReference()} {scriptureText.Trim()}";
    }

// function to choose a random word to hide by assigning a random index
    public void HideRandomWords(int count)
    {
    Random random = new Random();
    for (int i = 0; i < count; i++)
    {
        int index = random.Next(0, _words.Count);
        _words[index].Hide();
    }
}

  //checks if all words are hidden so that the program can end
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
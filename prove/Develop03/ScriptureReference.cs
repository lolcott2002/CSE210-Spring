// ScriptureReference.cs
public class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse; 

// for my current selection (a single verse)
    public ScriptureReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _lastVerse = verse;
    }

// if someone were to access the code and change it to a range
    public ScriptureReference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

// formats the refrence into a printable string
    public string GetFinalReference()
    {
        if (_firstVerse == _lastVerse)
        {
            return $"{_book} {_chapter}:{_firstVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        }
    }
}
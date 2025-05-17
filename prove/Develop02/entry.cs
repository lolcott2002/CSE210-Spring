using System;

public class Entry
{
    private string _creationDate;
    private string _creationTime;
    private string _prompt;
    private string _userEntry;

    public Entry(string prompt)
    {
        DateTime theCurrentTime = DateTime.Now;
        _creationDate = theCurrentTime.ToShortDateString();
        _creationTime = theCurrentTime.ToShortTimeString();
        _prompt = prompt;
        _userEntry = "";
    }
    public string GetCreationDate()
    {
        return _creationDate;
    }

    public string GetCreationTime()
    {
        return _creationTime;
    }

    public string GetPrompt()
    {
        return _prompt;
    }
    public string GetUserEntry()
    {
        return _userEntry;
    }

    public void SetUserEntry(string value)
    {
        _userEntry = value;
    }

    public override string ToString()
    {
        return $"Date: {_creationDate} Time: {_creationTime}\nPrompt: {_prompt}\nEntry: {_userEntry}\n";
    }
}
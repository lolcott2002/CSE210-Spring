using System;
using System.Collections.Generic;

public class Comment
{
    private string _commenter;
    private string _commentWords;

    //creates a new comment which will store the commenters name and what the comment says
    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _commentWords = comment;
    }

    //this will get the commenter's name
    public string GetCommenter()
    {
        return _commenter;
    }

    //this will get what the comment says
    public string GetCommentWords()
    {
        return _commentWords;
    }
}
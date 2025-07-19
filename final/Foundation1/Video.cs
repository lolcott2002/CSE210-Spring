public class Video
{
    private string _title;
    private string _creator;
    private int _length;
    private List<Comment> _comments;

    //creates a video and gets the author, length, and name of the video. It also starts a list of comments.
    public Video(string title, string creator, int length)
    {
        _title = title;
        _creator = creator;
        _length = length;
        _comments = new List<Comment>();
    }

    //videos title
    public string GetTitle()
    {
        return _title;
    }

    //videos creator
    public string GetCreator()
    {
        return _creator;
    }

    //videos length
    public int GetLength()
    {
        return _length;
    }

    //retrieves the list of comments
    public List<Comment> GetComments()
    {
        return _comments;
    }

    //adds a comment to the list
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    //gives the total number of comments
    public int NumberOfComments()
    {
        return _comments.Count;
    }
}
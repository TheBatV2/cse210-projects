public class Video
{
    private string _creator;
    private string _title;
    private string _length;
    private List<Comments> _comments = new List<Comments>();

    public Video(string creator, string title, string length)
    {
        _creator = creator;
        _title = title;
        _length = length;
    }
    public void comment(string author, string comment)
    {
        Comments newComment = new Comments(author, comment);
        _comments.Add(newComment);

    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}, By: {_creator}. Length{_length}");
        foreach (Comments comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}
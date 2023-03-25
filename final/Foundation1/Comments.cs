public class Comments
{
    private string _author;
    private string _comment;


    public Comments(string author, string comment)
    {
        _author = author;
        _comment = comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_author}: {_comment}");
    }

}
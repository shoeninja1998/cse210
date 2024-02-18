public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;
    public string DisplayVideoInfo()
    {
        return $"{_title} by {_author}, {_length}";
    }
}
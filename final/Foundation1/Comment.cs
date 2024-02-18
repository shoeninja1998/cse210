public class Comment
{
    public string _name;
    public string _text;
    public string DisplayComment()
    {
        return $"{_name}: {_text}";
    }
}
public class WritingAssignment:Assignment
{
    private string _title;
    public WritingAssignment(string Title, string StudentName, string Topic):base(StudentName, Topic)
    {
        _title = Title;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}
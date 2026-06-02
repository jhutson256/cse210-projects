public class WritingAssignment : Assignment
{
    private string _jphTitle;

    public WritingAssignment(string jph_studentName, string jph_topic, string jph_title) : base(jph_studentName, jph_topic)
    {
        _jphTitle = jph_title;
    }

    public string GetWritingInformation()
    {
        string jph_studentName = GetStudentName();
        return $"{_jphTitle} by {jph_studentName}";
    }
}
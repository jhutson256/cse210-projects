public class Assignment
{
    private string _jphStudentName;
    private string _jphTopic;

    public Assignment(string jph_studentName, string jph_topic)
    {
        _jphStudentName = jph_studentName;
        _jphTopic = jph_topic;
    }

    public string GetStudentName()
    {
        return _jphStudentName;
    }
    public string GetTopic()
    {
        return _jphTopic;
    }
    public string GetSummary()
    {
        return _jphStudentName + " - " + _jphTopic;
    }
}
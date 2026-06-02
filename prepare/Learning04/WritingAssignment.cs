public class MathAssignment : Assignment
{
    private string _jphTextbookSection;
    private string _jphProblems;

    public MathAssignment(string jph_studentName, string jph_topic, string jph_textbookSection, string jph_problems) : base(jph_studentName, jph_topic)
    {
        _jphTextbookSection = jph_textbookSection;
        _jphProblems = jph_problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_jphTextbookSection} Problems {_jphProblems}";
    }
}
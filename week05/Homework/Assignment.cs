public class Assignment
{
    private string _studentName;
    private string _topic;
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"Name of of the student - {_studentName} and the topic {_topic}";
    }
    public string GetName()
    {
        return _studentName;
    }
}


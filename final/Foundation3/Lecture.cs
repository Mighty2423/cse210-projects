public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string date, string time, string address, string speaker, int capacity)
        : base(title, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
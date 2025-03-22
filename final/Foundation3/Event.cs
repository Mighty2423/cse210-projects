public class Event
{
    private string _title;
    private string _date;
    private string _time;
    private string _address;

    public Event(string title, string date, string time, string address)
    {
        _title = title;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle() => _title;
    public string GetDate() => _date;
    public string GetTime() => _time;
    public string GetAddress() => _address;

    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDate: {_date} | Time: {_time}\nAddress: {_address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{_title} on {_date}";
    }
}
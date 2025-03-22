

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string date, string time, string address, string rsvpEmail)
        : base(title, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}
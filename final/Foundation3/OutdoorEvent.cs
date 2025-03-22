public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string date, string time, string address, string weather)
        : base(title, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Event\nWeather Forecast: {_weather}";
    }
}



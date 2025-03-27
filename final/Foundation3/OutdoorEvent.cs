public class OutdoorEvent : Event
{
    // Fields to store outdoor event-specific details
    // These fields are private to encapsulate the data
    //of weather forecast
    private string _weather;

    // outdoor event constructor
    // This constructor is public to allow instantiation of the class
    // with the required parameters.
    public OutdoorEvent(string title, string date, string time, string address, string weather)
        : base(title, date, time, address)
        // The details of the event are passed to the base class constructor
        //of Event class. with the parameters title, date, time, and address respectively.
    {
        // Constructor to initialize the outdoor event-specific details
        // of the weather forecast.
        _weather = weather;
    }

    // Properties to get the outdoor event details
    // These properties are public to allow access to the outdoor event details
    //The Getter for the weather forecast of the outdoor event
    // This property is public to allow access to the weather forecast of the outdoor event
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} Type: Outdoor Event\nWeather Forecast: {_weather}";
    }
}



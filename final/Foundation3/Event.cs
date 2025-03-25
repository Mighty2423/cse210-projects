
public class Event
{
    // Fields to store event details
    // These fields are private to encapsulate the data
    // and ensure they are only modified through methods of this class.
    // The fields are marked as private to restrict direct access from outside the class.


    // These fields are used to store the event's title, date, time, and address respectively.
    private string _title;
    private string _date;
    private string _time;
    private string _address;

    // Properties to expose the fields with public getters
    // and private setters to maintain encapsulation.
    public Event(string title, string date, string time, string address)
    {
        // Constructor to initialize the event details
        // This constructor is public to allow instantiation of the class
        // with the required parameters.
        // The parameters are title, date, time, and address respectively.
        _title = title;
        _date = date;
        _time = time;
        _address = address;
    }

    // Properties to get the event details
    // These properties are public to allow access to the event details

    // Getter for the title of the event
    // This property is public to allow access to the title of the event
    public string GetTitle() => _title;

    // Getter for the date of the event
    // This property is public to allow access to the date of the event
    public string GetDate() => _date;

    // Getter for the time of the event
    // This property is public to allow access to the time of the event

    public string GetTime() => _time;
    // Getter for the address of the event
    // This property is public to allow access to the address of the event
    public string GetAddress() => _address;

    // Methods to get event details in different formats
    // These methods are public to allow access to the event details in different formats
    // These methods are virtual to allow overriding in derived classes
    // This method returns the standard details of the event
    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDate: {_date} | Time: {_time}\nAddress: {_address}";
    }

    // This method returns the full details of the event
    // This method is virtual to allow overriding in derived classes
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    // This method returns the short description of the event
    // This method is virtual to allow overriding in derived classes
    // This method returns a short description of the event
    public virtual string GetShortDescription()
    {
        return $"{_title} on {_date}";
    }
}
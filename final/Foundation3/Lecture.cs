public class Lecture : Event
{
    // Fields to store lecture-specific details
    // These fields are private to encapsulate the data
    // and ensure they are only modified through methods of this class.

    // private string _title and _date, _time, _address are inherited from Event class
    private string _speaker;
    private int _capacity;

    // Properties to expose the fields with public getters
    // and private setters to maintain encapsulation.
    //lecture constructor
    // This constructor is public to allow instantiation of the class
    // with the required parameters.
    public Lecture(string title, string date, string time, string address, string speaker, int capacity)
        : base(title, date, time, address)
        // The details of the event are passed to the base class constructor
        //of Event class. with the parameters title, date, time, and address respectively.
    {
        // Constructor to initialize the lecture-specific details
        // of the lecture speaker and capacity.
        _speaker = speaker;
        _capacity = capacity;
    }

    // Properties to get the lecture details
    // These properties are public to allow access to the lecture details
    //The Getter for the speaker of the lecture
    // This property is public to allow access to the speaker of the lecture
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
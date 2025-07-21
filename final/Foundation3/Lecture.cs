using System.Text;
public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;


    //makes a new lecture event
    public Lecture(string title, string description, string date, string time, Address address,
                   string speakerName, int capacity) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }


    public string GetSpeakerName()
    {
        return _speakerName;
    }


    public int GetCapacity()
    {
        return _capacity;
    }


    public override string GetFullDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.GetStandardDetails());
        sb.AppendLine($"Event Type: Lecture");
        sb.AppendLine($"Event Speaker: {_speakerName}");
        sb.AppendLine($"Event Capacity: supports {_capacity} people");
        return sb.ToString();
    }


    public new string GetLittleDescription()
    {
        return $"Type: Lecture - Event Title: {GetEventTitle()} - Date of Event: {GetDate()}";
    }
}





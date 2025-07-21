using System.Text;
public class Reception : Event
{
    private string _rsvpEmail;


    //makes a reception event
    public Reception(string title, string description, string date, string time, Address address,
                     string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }


    public string GetRsvpEmail()
    {
        return _rsvpEmail;
    }


    //gives detials on reception
    public override string GetFullDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.GetStandardDetails());
        sb.AppendLine($"Type: Reception");
        sb.AppendLine($"RSVP Email: {_rsvpEmail}");
        return sb.ToString();
    }
    public new string GetLittleDescription()
    {
        return $"Type: Reception - Title: {GetEventTitle()} - Date: {GetDate()}";
    }
}

using System.Text;
public class OutdoorGathering : Event
{
    private string _weatherForecast;
    //new outdoor event
    public OutdoorGathering(string title, string description, string date, string time, Address address,
                            string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
    public string GetWeatherForecast()
    {
        return _weatherForecast;
    }
    public override string GetFullDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.GetStandardDetails());
        sb.AppendLine($"Type: Outdoor Gathering");
        sb.AppendLine($"Weather Forecast: {_weatherForecast}");
        return sb.ToString();
    }
    public new string GetLittleDescription()
    {
        return $"Type: Outdoor Gathering - Event Title: {GetEventTitle()} - Date of Event: {GetDate()}";
    }
}





using System;
using System.Collections.Generic;
using System.Text;
public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;


    //creates a new event
    public Event(string title, string description, string date, string time, Address address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }


    public string GetEventTitle()
    {
        return _eventTitle;
    }


    public string GetDescription()
    {
        return _description;
    }


    public string GetDate()
    {
        return _date;
    }


    public string GetTime()
    {
        return _time;
    }


    public Address GetAddress()
    {
        return _address;
    }


    public string GetStandardDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Event Name: {_eventTitle}");
        sb.AppendLine($"Description: {_description}");
        sb.AppendLine($"Event Date: {_date}");
        sb.AppendLine($"Time of Event: {_time}");
        sb.AppendLine($"Event Address:\n{_address.GetFullAddress()}");
        return sb.ToString();
    }


    public virtual string GetFullDetails()
    {
        return "ERROR: no full details available";
    }


    public string GetLittleDescription()
    {
        return $"Event: {_eventTitle} - {_date}";
    }
}



using System.Text;
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _postalCode;
    private string _country;


    //makes an address
    public Address(string streetAddress, string city, string state, string postalCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _postalCode = postalCode;
        _country = country;
    }


    public string GetStreetAddress()
    {
        return _streetAddress;
    }


    public string GetCity()
    {
        return _city;
    }


    public string GetState()
    {
        return _state;
    }


    public string GetpostalCode()
    {
        return _postalCode;
    }


    public string GetCountry()
    {
        return _country;
    }


    //formats the entire address
    public string GetFullAddress()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(_streetAddress);
        sb.AppendLine($"{_city}, {_state} {_postalCode}");
        sb.AppendLine(_country);
        return sb.ToString();
    }
}

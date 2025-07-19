using System.Text;
public class Address
{
    private string _customerAddress;
    private string _city;
    private string _state;
    private string _country;

    //makes a new address
    public Address(string streetAddress, string city, string state, string country)
    {
        _customerAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    //sets the country
    public string GetCountry()
    {
        return _country;
    }

    //makes sure the address is in the US of A
    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

     //returns the address
    public string GetAddressString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(_customerAddress);
        sb.AppendLine($"{_city}, {_state}");
        sb.AppendLine(_country);
        return sb.ToString();
    }
}
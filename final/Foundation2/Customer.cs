// Represents a customer.
public class Customer
{
    private string _name;
    private Address _address;

    //new customer
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //customers name
    public string Name
    {
        get { return _name; }
    }

    //customers address
    public Address Address
    {
        get { return _address; }
    }

    //makes sure they live in the US of A
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}

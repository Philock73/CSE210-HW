class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public Customer()
    {
        
    }

    public bool WhereLive()
    {
        return _address.CheckLocation();
    }

    public (string, string) ShippingLable()
    {
        return (_name, _address.DisplayAddress());
    }

}
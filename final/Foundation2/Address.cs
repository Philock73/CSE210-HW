class Address
{
    private string _street;

    private string _state;

    private string _city;

    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool CheckLocation()
    {
        bool international = false;
        if(_country != "USA")
        {
            international = true;
        }
        return international;
    }

    public string DisplayAddress()
    {
        return $"{_street} {_city}\n{_state}, {_country}";
    }
}
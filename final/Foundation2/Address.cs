// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetShippingLabel(Customer customer)
    {
        return $"{customer.GetCustomer()}.\n{_streetAddress}\n{_city}. {_stateProvince}.\n{_country}";
    }
}
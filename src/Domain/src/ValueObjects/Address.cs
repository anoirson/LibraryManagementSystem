namespace LibraryManagementSystem.Domain;

public partial class Address
{
    public Address(string street, string city, string state, string country, string codeAddress)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
        CodeAddress = codeAddress;
    }

    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }
    public string CodeAddress { get; private set; }

    public override string ToString()
    {
        return $"{Street}, {City}, {State}, {Country}, {CodeAddress}";
    }

}

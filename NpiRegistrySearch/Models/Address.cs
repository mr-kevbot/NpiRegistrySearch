namespace NpiRegistrySearch.Models
{
    public class Address
    {
        public AddressPurpose AddressPurpose { get; internal set; }
        public string AddressType { get; internal set; }
        public string Address1 { get; internal set; }
        public string Address2 { get; internal set; }
        public string City { get; internal set; }
        public string State { get; internal set; }
        public string PostalCode { get; internal set; }
        public string TelephoneNumber { get; internal set; }
        public string FaxNumber { get; internal set; }
        public string CountryCode { get; internal set; }
        public string Country { get; internal set; }
    }
}

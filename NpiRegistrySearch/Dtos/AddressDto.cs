using Newtonsoft.Json;

namespace NpiRegistrySearch.Dtos
{
    class AddressDto
    {
        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("address_purpose")]
        public string AddressPurpose { get; set; }

        [JsonProperty("address_type")]
        public string AddressType { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("fax_number")]
        public string FaxNumber { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("telephone_number")]
        public string TelephoneNumber { get; set; }
    }
}

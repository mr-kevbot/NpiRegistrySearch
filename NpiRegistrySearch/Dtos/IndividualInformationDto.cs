using Newtonsoft.Json;

namespace NpiRegistrySearch.Dtos
{
    class IndividualInformationDto
    {
        [JsonProperty("name")]
        public string Name { get; protected set; }

        [JsonProperty("name_prefix")]
        public string NamePrefix { get; protected set; }

        [JsonProperty("first_name")]
        public string FirstName { get; protected set; }

        [JsonProperty("last_name")]
        public string LastName { get; protected set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; protected set; }

        [JsonProperty("name_suffix")]
        public string NameSuffix { get; protected set; }

        [JsonProperty("credential")]
        public string Credential { get; protected set; }

        [JsonProperty("sole_proprietor")]
        public string SoleProprietor { get; protected set; }

        [JsonProperty("enumeration_date")]
        public string EnumerationDate { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

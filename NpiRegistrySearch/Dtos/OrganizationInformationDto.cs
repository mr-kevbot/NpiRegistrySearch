using Newtonsoft.Json;

namespace NpiRegistrySearch.Dtos
{
    class OrganizationInformationDto
    {
        [JsonProperty("organization_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("authorized_official_name_prefix")]
        public string AuthorizedOfficialNamePrefix { get; set; }

        [JsonProperty("authorized_official_first_name")]
        public string AuthorizedOfficialFirstName { get; set; }

        [JsonProperty("authorized_official_last_name")]
        public string AuthorizedOfficialLastName { get; set; }

        [JsonProperty("authorized_official_title_or_position")]
        public string AuthorizedOfficialTitle { get; set; }

        [JsonProperty("authorized_official_credential")]
        public string AuthorizedOfficialCredential { get; set; }

        [JsonProperty("authorized_official_telephone_number")]
        public string AuthorizedOfficialTelephoneNumber { get; set; }

        [JsonProperty("organizational_subpart")]
        public string OrganizationalSubpart { get; set; }

        [JsonProperty("enumeration_date")]
        public string EnumerationDate { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
        
    }
}

using Newtonsoft.Json;

namespace NpiRegistrySearch.Dtos
{
    class TaxonomyDto
    {
        [JsonProperty("code")]
        public string Code { get;  set; }

        [JsonProperty("desc")]
        public string Description { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("")]
        public string TaxonomyGroup { get; set; }
    }
}

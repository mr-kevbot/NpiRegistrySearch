using Newtonsoft.Json;

namespace NpiRegistrySearch.Dtos
{
    class ErrorDto
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}

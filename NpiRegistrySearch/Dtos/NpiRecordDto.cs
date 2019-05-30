using Newtonsoft.Json;
using System.Collections.Generic;

namespace NpiRegistrySearch.Dtos
{
    internal class NpiRecordDto
    {
        [JsonProperty("number")]
        internal int Number { get; set; }

        [JsonProperty("taxonomies")]
        internal IEnumerable<TaxonomyDto> Taxonomies { get; set; }

        [JsonProperty("addresses")]
        internal IEnumerable<AddressDto> Addresses { get; set; }

        [JsonProperty("enumeration_type")]
        internal string EnumerationType { get; set; }

        [JsonProperty("last_updated_epoch")]
        internal int CreatedEpoch { get; set; }

    }
}

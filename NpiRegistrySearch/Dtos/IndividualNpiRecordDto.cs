using Newtonsoft.Json;
using NpiRegistrySearch.Helpers;
using NpiRegistrySearch.Models;
using System.Linq;

namespace NpiRegistrySearch.Dtos
{
    internal class IndividualNpiRecordDto : NpiRecordDto
    {
        [JsonProperty("basic")]
        internal IndividualInformationDto IndividualInformation { get; set; }

        internal IndividualNpiRecord ToIndividualNpiRecord()
        {
            return new IndividualNpiRecord
            {
                Basic = new IndividualInformation
                {
                    FirstName = this.IndividualInformation.FirstName,
                    LastName = this.IndividualInformation.LastName,
                    MiddleName = this.IndividualInformation.MiddleName,
                    NameSuffix = this.IndividualInformation.NameSuffix,
                    SoleProprietor = this.IndividualInformation.SoleProprietor == "YES",
                    Credential = this.IndividualInformation.Credential,
                    Gender = this.IndividualInformation.Gender
                },
                Number = this.Number.ToString(),
                Taxonomies = this.Taxonomies.Select(x => new Taxonomy
                {
                    Code = x.Code,
                    Description = x.Description,
                    License = x.License,
                    Primary = x.Primary,
                    State = x.State,
                    TaxonomyGroup = x.TaxonomyGroup
                }),
                Addresses = this.Addresses.Select(x => new Address
                {
                    Address1 = x.Address1,
                    Address2 = x.Address2,
                    AddressPurpose = new AddressPurpose(x.AddressPurpose),
                    AddressType = x.AddressType,
                    City = x.City,
                    State = x.State,
                    Country = x.CountryName,
                    CountryCode = x.CountryCode,
                    PostalCode = x.PostalCode,
                    FaxNumber = x.FaxNumber,
                    TelephoneNumber = x.TelephoneNumber
                }),
                EnumerationType = Models.EnumerationType.Individual,
                CreatedDate = DateTimeHelper.FromUnixTime(this.CreatedEpoch),
                LastUpdatedDate = DateTimeHelper.FromUnixTime(this.CreatedEpoch)
            };
        }
    }
}

using Newtonsoft.Json;
using NpiRegistrySearch.Helpers;
using NpiRegistrySearch.Models;
using System;
using System.Linq;

namespace NpiRegistrySearch.Dtos
{
    internal class OrganizationNpiRecordDto : NpiRecordDto
    {
        [JsonProperty("basic")]
        internal OrganizationInformationDto OrganizationInformation { get; set; }
        
        internal OrganizationNpiRecord ToOrganizationNpiRecord()
        {
            return new OrganizationNpiRecord
            {
                Basic = new OrganizationInformation
                {
                    OrganizationName = this.OrganizationInformation.OrganizationName,
                    Name = this.OrganizationInformation.Name,
                    AuthorizedOfficialCredential = this.OrganizationInformation.AuthorizedOfficialCredential,
                    AuthorizedOfficialFirstName = this.OrganizationInformation.AuthorizedOfficialFirstName,
                    AuthorizedOfficialLastName = this.OrganizationInformation.AuthorizedOfficialLastName,
                    AuthorizedOfficialNamePrefix = this.OrganizationInformation.AuthorizedOfficialNamePrefix,
                    AuthorizedOfficialTelephoneNumber = this.OrganizationInformation.AuthorizedOfficialTelephoneNumber,
                    AuthorizedOfficialTitle = this.OrganizationInformation.AuthorizedOfficialTitle,
                    OrganizationSubPart = this.OrganizationInformation.OrganizationalSubpart == "YES",
                    Status = this.OrganizationInformation.Status == "A" ? "ACTIVE" : "INACTIVE",
                    EnumerationDate = DateTime.Parse(this.OrganizationInformation.EnumerationDate),
                    LastUpdatedDate = DateTime.Parse(this.OrganizationInformation.LastUpdated)
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
                EnumerationType = Models.EnumerationType.Organization,
                CreatedDate = DateTimeHelper.FromUnixTime(this.CreatedEpoch),
                LastUpdatedDate = DateTimeHelper.FromUnixTime(this.CreatedEpoch)
            };
        }
    }
}

using System;

namespace NpiRegistrySearch.Models
{
    public class OrganizationInformation
    {
        public string Name { get; internal set; }
        public string OrganizationName { get; internal set; }
        public bool OrganizationSubPart { get; internal set; }
        public DateTime EnumerationDate { get; internal set; }
        public DateTime LastUpdatedDate { get; internal set; }
        public string Status { get; internal set; }
        public string AuthorizedOfficialCredential { get; internal set; }
        public string AuthorizedOfficialNamePrefix { get; internal set; }
        public string AuthorizedOfficialFirstName { get; internal set; }
        public string AuthorizedOfficialLastName { get; internal set; }
        public string AuthorizedOfficialTelephoneNumber { get; internal set; }
        public string AuthorizedOfficialTitle { get; internal set; }
    }
}

namespace NpiRegistrySearch.Models
{
    public class IndividualInformation
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string MiddleName { get; internal set; }
        public string NameSuffix { get; internal set; }
        public string Credential { get; internal set; }
        public bool SoleProprietor { get; internal set; }
        public string Gender { get; internal set; }
    }
}

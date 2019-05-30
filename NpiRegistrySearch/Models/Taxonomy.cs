namespace NpiRegistrySearch.Models
{
    public class Taxonomy
    {
        public string Code { get; protected set; }
        public string Description { get; protected set; }
        public bool Primary { get; protected set; }
        public string State { get; protected set; }
        public string License { get; protected set; }
        public string TaxonomyGroup { get; protected set; }
    }
}

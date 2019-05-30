namespace NpiRegistrySearch.Models
{
    public class Taxonomy
    {
        public string Code { get; internal set; }
        public string Description { get; internal set; }
        public bool Primary { get; internal set; }
        public string State { get; internal set; }
        public string License { get; internal set; }
        public string TaxonomyGroup { get; internal set; }
    }
}

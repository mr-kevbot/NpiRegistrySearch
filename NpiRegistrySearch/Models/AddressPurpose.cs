namespace NpiRegistrySearch.Models
{
    public class AddressPurpose
    {
        private string _value;

        private AddressPurpose() { }
        public AddressPurpose(string addressPurpose) => _value = addressPurpose;

        public override string ToString() => _value;

        public static string Location => "LOCATION";
        public static string Mailing => "MAILING";
        public static string Primary => "PRIMARY";
        public static string Secondary => "SECONDARY";
    }
}

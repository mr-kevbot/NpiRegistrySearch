namespace NpiRegistrySearch.Models
{
    public class EnumerationType
    {
        private string _value;
        
        public EnumerationType(string enumerationType)
        {
            switch (enumerationType.ToUpper())
            {
                case "NPI-1":
                case "INDIVIDUAL":
                    _value = "NPI-1";
                    break;
                case "NPI-2":
                case "ORGANIZATION":
                    _value = "NPI-2";
                    break;
            }
        }

        public override string ToString()
        {
            return _value;
        }

        public static EnumerationType Individual => new EnumerationType("NPI-1");
        public static EnumerationType Organization => new EnumerationType("NPI-2");

    }
}

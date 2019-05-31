using System;

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

        public override bool Equals(object obj)
        {
            var type = obj as EnumerationType;
            return type != null &&
                   _value == type._value;
        }

        public static bool operator ==(EnumerationType t1, EnumerationType t2)
        {
            if (System.Object.ReferenceEquals(t1, t2))
                return true;

            if (((object)t1 == null) || ((object)t2 == null))
                return false;

            return t1._value == t2._value;
        }

        public static bool operator !=(EnumerationType t1, EnumerationType t2)
        {
            return !(t1 == t2);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_value);
        }

        public static EnumerationType Individual => new EnumerationType("NPI-1");
        public static EnumerationType Organization => new EnumerationType("NPI-2");

    }
}

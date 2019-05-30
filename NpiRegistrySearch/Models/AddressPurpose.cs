using System;

namespace NpiRegistrySearch.Models
{
    public class AddressPurpose
    {
        private string _value;

        private AddressPurpose() { }
        public AddressPurpose(string addressPurpose) => _value = addressPurpose;

        public override string ToString() => _value;

        public override bool Equals(object obj)
        {
            var purpose = obj as AddressPurpose;
            return purpose != null &&
                   _value == purpose._value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_value);
        }

        public static AddressPurpose Location => new AddressPurpose("LOCATION");
        public static AddressPurpose Mailing => new AddressPurpose("MAILING");
        public static AddressPurpose Primary => new AddressPurpose("PRIMARY");
        public static AddressPurpose Secondary => new AddressPurpose("SECONDARY");
    }
}

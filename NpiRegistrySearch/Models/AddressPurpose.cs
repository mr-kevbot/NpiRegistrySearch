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

        public static bool operator ==(AddressPurpose p1, AddressPurpose p2)
        {
            if (System.Object.ReferenceEquals(p1, p2))
                return true;

            if (((object)p1 == null) || ((object)p2 == null))
                return false;

            return p1._value == p2._value;
        }

        public static bool operator !=(AddressPurpose p1, AddressPurpose p2)
        {
            return !(p1 == p2);
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

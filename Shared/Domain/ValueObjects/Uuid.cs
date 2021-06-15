using System;
using System.ComponentModel;

namespace Shared.Domain.ValueObjects
{
    public class Uuid
    {
        public string Value { get; }

        public Uuid(string value)
        {
            EnsureIsValidUuid(value);
            Value = value;
        }

        private void EnsureIsValidUuid(string value)
        {
            if (!Guid.TryParse(value, out var Uuid))
                throw new InvalidEnumArgumentException($"{value} is not a valid GUID");
        }

        public override string ToString()
        {
            return Value;
        }

        public static Uuid Random()
        {
            return new Uuid(Guid.NewGuid().ToString());
        }


        public override bool Equals(object obj)
        {
            if (this == obj) return true;

            var item = obj as Uuid;
            if (item == null) return false;

            return Value == item.Value;
        }

    }
}
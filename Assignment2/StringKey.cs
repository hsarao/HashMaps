using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class StringKey:IComparable<StringKey>
    {
        public String KeyName;
        public const double COEFFICIENT = 31;
        private int hashCode = 0;

        public override int GetHashCode()
        {            
            char[] charArray = KeyName.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                hashCode += (int)(charArray[i] * Math.Pow(COEFFICIENT, i));
            }
            return hashCode;
        }

        public StringKey(String name)
        {
            KeyName = name;
        }

        public override bool Equals(object o)
        {
            if (o == null)
            {
                return false;
            }

            StringKey item = o as StringKey;

            return (item != null)
                && (KeyName == item.KeyName);
        }

        public int CompareTo(StringKey obj)
        {
            return string.Compare(KeyName, obj.KeyName);
        }

        public override String ToString()
        {
            String result = "KeyName: " + KeyName + " HashCode: "+ GetHashCode();
            return result;
        }

        public String GetKeyName()
        {
            return this.KeyName;
        }

    }
}

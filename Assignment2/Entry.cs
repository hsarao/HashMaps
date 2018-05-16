using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Entry<K, V>
    {
        private K key;
        private V value;

        public Entry(K key, V value)
        {

        }

        public K GetKey()
        {
            return key;
        }

        public V GetValue()
        {
            return value;
        }

        public void setValue(V value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

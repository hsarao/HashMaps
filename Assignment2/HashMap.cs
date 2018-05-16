using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class HashMap<K, V> : Map<K, V>
    {
       public int Capacity;
        private double loadFactor;
        private int threshold;
        private int ssize = 0;

        public Entry<K, V>[] Table { get; set; }
        private const int DEFAULT_CAPACTIY = 11;
        private const double DEFAULT_LOADFACTOR = 0.75;

        public HashMap()
        {
            this.Capacity = DEFAULT_CAPACTIY;
            this.loadFactor = DEFAULT_LOADFACTOR;
            Table = new Entry<K, V>[DEFAULT_CAPACTIY];
            this.threshold = (int)(Capacity * loadFactor);
        }

        public HashMap(int intialcapacity)
        {
            if(intialcapacity <= 0)
            {
                throw new ArgumentException();
            }

            Table = new Entry<K, V>[intialcapacity];
            this.Capacity = intialcapacity;
            this.loadFactor = DEFAULT_LOADFACTOR;
            this.threshold = (int)(Capacity * loadFactor);
        }

        public HashMap(int capacity, double loadFactor)
        {
            if (capacity <= 0 || loadFactor < 0 || loadFactor > 1)
            {
                throw new ArgumentException();
            }

            this.Capacity = capacity;
            Table = new Entry<K, V>[capacity];
            this.loadFactor = loadFactor;
            this.threshold = (int)(Capacity * loadFactor);

        }

        public Entry<K, V>[] GetTable()
        {
            return Table;
        }

        public int Size()
        {
            return ssize;
        }

        public bool IsEmpty()
        {
            return ssize == 0;
        }

        public void Clear()
        {
            for (int i = 0; i < Table.Length; i++)
            {
                Table[i] = null;
            }
            ssize = 0;
        }

        public V Get(K key)
        {
            throw new NotImplementedException();
        }

        public V Put(K key, V value)
        {
            throw new NotImplementedException();
        }

        public V Remove(K Key)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<K> Keys()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<V> Values()
        {
            throw new NotImplementedException();
        }
    }
}

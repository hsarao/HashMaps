using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface Map<K, V>
    {
       
        int Size();
        
        bool IsEmpty();

        void Clear();
        V Get(K key);
        
        V Put(K key, V value);

        V Remove(K Key);

        IEnumerator<K> Keys();

        IEnumerator<V> Values();
    }
}

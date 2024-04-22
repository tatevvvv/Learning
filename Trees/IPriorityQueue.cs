using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal interface IPriorityQueue<K,V>
    {
        int Size();

        bool IsEmpty();

        KeyValuePair<K,V> Min();

        KeyValuePair<K,V> RemoveMin();

        KeyValuePair<K,V> Insert(K key, V value);

    }
}

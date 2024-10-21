using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class Pair<K, V>
    {
        public K key {  get; set; }
        public V value { get; set; }

        public Pair(K key, V value)
        {
            this.key = key;
            this.value = value;
        }
    }
}

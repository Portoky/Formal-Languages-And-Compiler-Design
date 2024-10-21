using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class SymbolTable
    {
        public HashTable Table { get; set; }

        public SymbolTable(int size)
        {
            this.Table = new HashTable(size);
        }

        public bool add(string value)
        {
            return this.Table.add(value);
        }

        public Pair<int, int>? findPosByValue(string value)
        { 
            return this.Table.findPosOfValue(value);
        }
        public string getSymbolTable()
        {
            return this.Table.getHashTable();
        }
    }
}

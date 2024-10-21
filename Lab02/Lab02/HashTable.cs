using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class HashTable
    {
        private List<List<string>> Table { get; set; }
        private int Size { get; set; }
        public HashTable(int size)
        {
            this.Size = size;
            this.Table = new List<List<string>>();

            for (int i = 0; i < Size; ++i)
            {
                this.Table.Add(new List<string>());
            }
        }

        public int hash(string key)
        {
            int sum_chars = 0;
            char[] key_characters = key.ToCharArray();
            foreach(char c in key_characters)
            {
                sum_chars += c;
            }
            return sum_chars % this.Size;
        }

        public Pair<int, int>? findPosOfValue(string value)
        {
            int pos = this.hash(value);

            List<string> list = this.Table[pos];
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i] == value)
                {
                    return new Pair<int, int>(pos, i);
                }
            }

            return null;
        }
        public bool add(string value)
        {
            if (this.findPosOfValue(value) != null)
            {
                return false;
            }

            int pos = this.hash(value);

            List<string> list = this.Table[pos];
            list.Add(value);

            return true;
        }
        public string getHashTable()
        {
            string result = "";
            for (int i = 0; i < Table.Count; i++)
            {
                for(int j = 0; j < Table[i].Count; j++)
                {
                    result += $"{i}, {j} -> {Table[i][j]}\n";
                }
            }

            return result;
        }
    }
}

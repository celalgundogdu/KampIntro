using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<K, V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            if (Search(key) == false)
            {
                K[] tempKeys = keys;
                V[] tempValues = values;

                keys = new K[keys.Length + 1];
                values = new V[values.Length + 1];

                for (int i = 0; i < tempKeys.Length; i++)
                {
                    keys[i] = tempKeys[i];
                    values[i] = tempValues[i];
                }

                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;
            }
            else
            {
                Console.WriteLine("This key can not used since it is already in the dictionary");
            }
            
        }

        public bool Search (K key) 
        {
            bool isExist = false;
            foreach (K item in keys)
            {
                if (item.Equals(key))
                {
                    isExist = true;
                    break;
                }
            }
            return isExist;
        }

        public K[] Keys
        {
            get { return keys; }
        }

        public V[] Values
        {
            get { return values; }
        }

        public void print()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " - " + values[i]);
            }
        }

    }
}

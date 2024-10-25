using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İndexerTask
{
    internal class StringList
    {

        private string[] cities;

        public StringList(string[] indexOfCity)
        {
            cities = indexOfCity;
        }

        // Indexer methoduu
        public int this[string cityName]
        {
            get
            {
                for (int i = 0; i < cities.Length; i++)
                {
                    if (cities[i] == cityName)
                    {
                        return i;
                    }
                }
                // sheher tapilmiir bele olanda asaguida
                return -1;
            }
        }
    }
}

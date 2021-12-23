using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace desktop_app
{

    static class FilterModule
    {
        

        static public IEnumerable<T> Filter<T>(IEnumerable<T> x, string whatField, int compType, T compVal) where T : IComparable<T>
        {
            switch (whatField)
            {

            }


        }


        static private IEnumerable<Guid> FilterPairList<T>(IEnumerable<KeyValuePair<Guid, T>> x, int type, T val) where T : IComparable<T>
        {
            switch (type)
            {
                case 1:// <
                    x = x.Where(y=> y.Value.CompareTo(val)  < 0).ToList();
                    break;
                case 2:// ==
                    x = x.Where(y => y.Value.CompareTo(val) == 0).ToList();
                    break;
                case 3:// >
                    x = x.Where(y => y.Value.CompareTo(val) > 0).ToList();
                    break;
            }
            return x.Select(y => y.Key).ToList();
        }
    }
}
